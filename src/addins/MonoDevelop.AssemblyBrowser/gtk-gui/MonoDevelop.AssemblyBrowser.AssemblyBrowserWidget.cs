
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.AssemblyBrowser
{
	internal partial class AssemblyBrowserWidget
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action NavigateBackwardAction;
		
		private global::Gtk.Action NavigateForwardAction;
		
		private global::Gtk.Action goBackAction;
		
		private global::Gtk.Action goForwardAction;
		
		private global::Gtk.Action goBackAction1;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Button buttonBack;
		
		private global::Gtk.Button buttonForeward;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.ComboBox languageCombobox;
		
		private global::Gtk.Label label1;
		
		private global::MonoDevelop.Components.SearchEntry searchentry1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.ComboBox comboboxVisibilty;
		
		private global::Gtk.HPaned hpaned1;
		
		private global::Gtk.Alignment treeViewPlaceholder;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.Notebook notebookInspection;
		
		private global::Gtk.ScrolledWindow documentationScrolledWindow;
		
		private global::Gtk.Label documentationLabel;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.VBox searchWidget;
		
		private global::Gtk.ScrolledWindow scrolledwindow1;
		
		private global::Gtk.TreeView searchTreeview;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.AssemblyBrowser.AssemblyBrowserWidget
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.NavigateBackwardAction = new global::Gtk.Action ("NavigateBackwardAction", global::Mono.Unix.Catalog.GetString ("Navigate backward"), null, "gtk-go-back");
			this.NavigateBackwardAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Navigate backward");
			w2.Add (this.NavigateBackwardAction, null);
			this.NavigateForwardAction = new global::Gtk.Action ("NavigateForwardAction", global::Mono.Unix.Catalog.GetString ("Navigate forward"), null, "gtk-go-forward");
			this.NavigateForwardAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Navigate forward");
			w2.Add (this.NavigateForwardAction, null);
			this.goBackAction = new global::Gtk.Action ("goBackAction", null, null, "gtk-go-back");
			w2.Add (this.goBackAction, null);
			this.goForwardAction = new global::Gtk.Action ("goForwardAction", null, null, "gtk-go-forward");
			w2.Add (this.goForwardAction, null);
			this.goBackAction1 = new global::Gtk.Action ("goBackAction1", null, null, "gtk-go-back");
			w2.Add (this.goBackAction1, null);
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "MonoDevelop.AssemblyBrowser.AssemblyBrowserWidget";
			// Container child MonoDevelop.AssemblyBrowser.AssemblyBrowserWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonBack = new global::Gtk.Button ();
			this.buttonBack.CanFocus = true;
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.UseStock = true;
			this.buttonBack.UseUnderline = true;
			this.buttonBack.Label = "gtk-go-back";
			this.hbox2.Add (this.buttonBack);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonBack]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonForeward = new global::Gtk.Button ();
			this.buttonForeward.CanFocus = true;
			this.buttonForeward.Name = "buttonForeward";
			this.buttonForeward.UseStock = true;
			this.buttonForeward.UseUnderline = true;
			this.buttonForeward.Label = "gtk-go-forward";
			this.hbox2.Add (this.buttonForeward);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonForeward]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("_Visibility:");
			this.label3.UseUnderline = true;
			this.hbox2.Add (this.label3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label3]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.languageCombobox = global::Gtk.ComboBox.NewText ();
			this.languageCombobox.Name = "languageCombobox";
			this.hbox2.Add (this.languageCombobox);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.languageCombobox]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Language:");
			this.label1.UseUnderline = true;
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.searchentry1 = new global::MonoDevelop.Components.SearchEntry ();
			this.searchentry1.Name = "searchentry1";
			this.searchentry1.ForceFilterButtonVisible = false;
			this.searchentry1.IsCheckMenu = false;
			this.searchentry1.ActiveFilterID = 0;
			this.searchentry1.Ready = false;
			this.searchentry1.HasFocus = false;
			this.hbox2.Add (this.searchentry1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.searchentry1]));
			w8.PackType = ((global::Gtk.PackType)(1));
			w8.Position = 5;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("_Search:");
			this.label2.UseUnderline = true;
			this.hbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label2]));
			w9.PackType = ((global::Gtk.PackType)(1));
			w9.Position = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboboxVisibilty = global::Gtk.ComboBox.NewText ();
			this.comboboxVisibilty.Name = "comboboxVisibilty";
			this.hbox2.Add (this.comboboxVisibilty);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.comboboxVisibilty]));
			w10.PackType = ((global::Gtk.PackType)(1));
			w10.Position = 7;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 271;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.treeViewPlaceholder = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.treeViewPlaceholder.Name = "treeViewPlaceholder";
			this.hpaned1.Add (this.treeViewPlaceholder);
			global::Gtk.Paned.PanedChild w12 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.treeViewPlaceholder]));
			w12.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			this.notebook1.ShowBorder = false;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.notebookInspection = new global::Gtk.Notebook ();
			this.notebookInspection.CanFocus = true;
			this.notebookInspection.Name = "notebookInspection";
			this.notebookInspection.CurrentPage = 1;
			// Container child notebookInspection.Gtk.Notebook+NotebookChild
			this.documentationScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.documentationScrolledWindow.Name = "documentationScrolledWindow";
			this.documentationScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child documentationScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w13 = new global::Gtk.Viewport ();
			w13.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.documentationLabel = new global::Gtk.Label ();
			this.documentationLabel.Name = "documentationLabel";
			this.documentationLabel.Xpad = 6;
			this.documentationLabel.Ypad = 6;
			this.documentationLabel.Xalign = 0F;
			this.documentationLabel.Yalign = 0F;
			this.documentationLabel.UseMarkup = true;
			this.documentationLabel.Selectable = true;
			w13.Add (this.documentationLabel);
			this.documentationScrolledWindow.Add (w13);
			this.notebookInspection.Add (this.documentationScrolledWindow);
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("summary");
			this.notebookInspection.SetTabLabel (this.documentationScrolledWindow, this.label4);
			this.label4.ShowAll ();
			// Notebook tab
			global::Gtk.Label w17 = new global::Gtk.Label ();
			w17.Visible = true;
			this.notebookInspection.Add (w17);
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("decompiler");
			this.notebookInspection.SetTabLabel (w17, this.label5);
			this.label5.ShowAll ();
			this.notebook1.Add (this.notebookInspection);
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.searchWidget = new global::Gtk.VBox ();
			this.searchWidget.Name = "searchWidget";
			this.searchWidget.Spacing = 6;
			// Container child searchWidget.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.searchTreeview = new global::Gtk.TreeView ();
			this.searchTreeview.CanFocus = true;
			this.searchTreeview.Name = "searchTreeview";
			this.scrolledwindow1.Add (this.searchTreeview);
			this.searchWidget.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.searchWidget [this.scrolledwindow1]));
			w20.Position = 0;
			this.notebook1.Add (this.searchWidget);
			global::Gtk.Notebook.NotebookChild w21 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.searchWidget]));
			w21.Position = 1;
			this.vbox3.Add (this.notebook1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.notebook1]));
			w22.Position = 0;
			this.hpaned1.Add (this.vbox3);
			this.vbox1.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hpaned1]));
			w24.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.label3.MnemonicWidget = this.comboboxVisibilty;
			this.label1.MnemonicWidget = this.languageCombobox;
			this.label2.MnemonicWidget = this.searchentry1;
			this.Show ();
			this.NavigateBackwardAction.Activated += new global::System.EventHandler (this.OnNavigateBackwardActionActivated);
			this.NavigateForwardAction.Activated += new global::System.EventHandler (this.OnNavigateForwardActionActivated);
		}
	}
}
