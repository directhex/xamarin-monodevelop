
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.StandardHeader
{
	internal partial class StandardHeaderPolicyPanelWidget
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView headerText;

		private global::Gtk.CheckButton includeAutoCheck;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.StandardHeader.StandardHeaderPolicyPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Ide.StandardHeader.StandardHeaderPolicyPanelWidget";
			// Container child MonoDevelop.Ide.StandardHeader.StandardHeaderPolicyPanelWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.headerText = new global::Gtk.TextView ();
			this.headerText.CanFocus = true;
			this.headerText.Name = "headerText";
			this.GtkScrolledWindow.Add (this.headerText);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.includeAutoCheck = new global::Gtk.CheckButton ();
			this.includeAutoCheck.CanFocus = true;
			this.includeAutoCheck.Name = "includeAutoCheck";
			this.includeAutoCheck.Label = global::MonoDevelop.Core.GettextCatalog.GetString ("_Include standard header in new files");
			this.includeAutoCheck.DrawIndicator = true;
			this.includeAutoCheck.UseUnderline = true;
			this.vbox2.Add (this.includeAutoCheck);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.includeAutoCheck]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
