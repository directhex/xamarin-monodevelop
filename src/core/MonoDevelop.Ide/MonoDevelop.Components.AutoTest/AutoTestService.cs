// 
// AutoTestService.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using MonoDevelop.Components.Commands;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Remoting.Channels;
using System.Collections;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Remoting;
using System.Collections.Generic;

namespace MonoDevelop.Components.AutoTest
{
	public static class AutoTestService
	{
		static CommandManager commandManager;
		static AutoTestServiceManager manager = new AutoTestServiceManager ();
		
		public static void Start (CommandManager commandManager, bool publishServer)
		{
			AutoTestService.commandManager = commandManager;
			
			string sref = Environment.GetEnvironmentVariable ("MONO_AUTOTEST_CLIENT");
			if (!string.IsNullOrEmpty (sref)) {
				Console.WriteLine ("AutoTest service starting");
				SetupRemoting ();
				byte[] data = Convert.FromBase64String (sref);
				MemoryStream ms = new MemoryStream (data);
				BinaryFormatter bf = new BinaryFormatter ();
				IAutoTestClient client = (IAutoTestClient) bf.Deserialize (ms);
				client.Connect (manager.AttachClient (client));
			}
			if (publishServer && !manager.IsClientConnected) {
				SetupRemoting ();
				BinaryFormatter bf = new BinaryFormatter ();
				ObjRef oref = RemotingServices.Marshal (manager);
				MemoryStream ms = new MemoryStream ();
				bf.Serialize (ms, oref);
				sref = Convert.ToBase64String (ms.ToArray ());
				File.WriteAllText (SessionReferenceFile, sref);
			}
		}
		
		internal static string SessionReferenceFile {
			get {
				return Path.Combine (Path.GetTempPath (), "monodevelop-autotest-objref");
			}
		}
		
		internal static CommandManager CommandManager {
			get { return commandManager; }
		}
		
		public static void NotifyEvent (string eventName)
		{
			if (manager.IsClientConnected)
				manager.NotifyEvent (eventName);
		}
		
		internal static void SetupRemoting ()
		{
			IChannel ch = ChannelServices.GetChannel ("ipc");
			if (ch == null) {
				IDictionary dict = new Hashtable ();
				BinaryClientFormatterSinkProvider clientProvider = new BinaryClientFormatterSinkProvider();
				BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
				string unixRemotingFile = Path.GetTempFileName ();
				dict ["portName"] = Path.GetFileName (unixRemotingFile);
				serverProvider.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
				ChannelServices.RegisterChannel (new IpcChannel (dict, clientProvider, serverProvider), false);
			}
		}
	}
	
	class AutoTestServiceManager: MarshalByRefObject, IAutoTestService
	{
		IAutoTestClient client;
		AutoTestSession currentSession;
		
		public override object InitializeLifetimeService ()
		{
			return null;
		}
		
		public bool IsClientConnected {
			get { return client != null; }
		}
		
		public void NotifyEvent (string eventName)
		{
			try {
				client.NotifyEvent (eventName);
			}
			catch (Exception ex) {
				Console.WriteLine ("Dropping autotest client: " + ex.Message);
				client = null;
			}
		}
			
		public AutoTestSession AttachClient (IAutoTestClient client)
		{
			if (this.client != null) {
				// Make sure the current client is alive
				NotifyEvent ("Ping");
				if (this.client != null)
					throw new InvalidOperationException ("A client is already connected");
			}
			this.client = client;
			if (currentSession == null)
				currentSession = new AutoTestSession ();
			return currentSession;
		}
		
		public void DetachClient (IAutoTestClient client)
		{
			if (client == this.client)
				this.client = null;
			else
				throw new InvalidOperationException ("Not connected");
		}
	}
	
	public interface IAutoTestService
	{
		AutoTestSession AttachClient (IAutoTestClient client);
		void DetachClient (IAutoTestClient client);
	}
}
