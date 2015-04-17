
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Frame frame3;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.TextView textview4;
	
	private global::Gtk.Label GtkLabel;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Frame frame5;
	
	private global::Gtk.Alignment GtkAlignment1;
	
	private global::Gtk.VBox vbox7;
	
	private global::Gtk.CheckButton checkbutton8;
	
	private global::Gtk.CheckButton checkbutton9;
	
	private global::Gtk.CheckButton checkbutton10;
	
	private global::Gtk.Label GtkLabel3;
	
	private global::Gtk.Frame frame6;
	
	private global::Gtk.Alignment GtkAlignment2;
	
	private global::Gtk.VBox vbox11;
	
	private global::Gtk.CheckButton proxyCheckButton;
	
	private global::Gtk.TextView proxyUrlTextView;
	
	private global::Gtk.CheckButton socketTimeoutCheckButton;
	
	private global::Gtk.TextView socketTimeoutTextView;
	
	private global::Gtk.Label GtkLabel6;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.Button button16;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("YoutubeDL");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame3 = new global::Gtk.Frame ();
		this.frame3.Name = "frame3";
		this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
		this.frame3.LabelXalign = 0.5F;
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.textview4 = new global::Gtk.TextView ();
		this.textview4.CanFocus = true;
		this.textview4.Name = "textview4";
		this.textview4.AcceptsTab = false;
		this.textview4.PixelsAboveLines = 2;
		this.textview4.PixelsBelowLines = 2;
		this.GtkAlignment.Add (this.textview4);
		this.frame3.Add (this.GtkAlignment);
		this.GtkLabel = new global::Gtk.Label ();
		this.GtkLabel.Name = "GtkLabel";
		this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Youtube Video URL</b>");
		this.GtkLabel.UseMarkup = true;
		this.frame3.LabelWidget = this.GtkLabel;
		this.vbox1.Add (this.frame3);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame3]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Homogeneous = true;
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.frame5 = new global::Gtk.Frame ();
		this.frame5.Name = "frame5";
		this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame5.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.checkbutton8 = new global::Gtk.CheckButton ();
		this.checkbutton8.CanFocus = true;
		this.checkbutton8.Name = "checkbutton8";
		this.checkbutton8.Label = global::Mono.Unix.Catalog.GetString ("Abort on error");
		this.checkbutton8.DrawIndicator = true;
		this.checkbutton8.UseUnderline = true;
		this.vbox7.Add (this.checkbutton8);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.checkbutton8]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.checkbutton9 = new global::Gtk.CheckButton ();
		this.checkbutton9.CanFocus = true;
		this.checkbutton9.Name = "checkbutton9";
		this.checkbutton9.Label = global::Mono.Unix.Catalog.GetString ("Ignore config");
		this.checkbutton9.DrawIndicator = true;
		this.checkbutton9.UseUnderline = true;
		this.vbox7.Add (this.checkbutton9);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.checkbutton9]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.checkbutton10 = new global::Gtk.CheckButton ();
		this.checkbutton10.CanFocus = true;
		this.checkbutton10.Name = "checkbutton10";
		this.checkbutton10.Label = global::Mono.Unix.Catalog.GetString ("Flat playlist");
		this.checkbutton10.DrawIndicator = true;
		this.checkbutton10.UseUnderline = true;
		this.vbox7.Add (this.checkbutton10);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.checkbutton10]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.GtkAlignment1.Add (this.vbox7);
		this.frame5.Add (this.GtkAlignment1);
		this.GtkLabel3 = new global::Gtk.Label ();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>General Options</b>");
		this.GtkLabel3.UseMarkup = true;
		this.frame5.LabelWidget = this.GtkLabel3;
		this.hbox2.Add (this.frame5);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame5]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.frame6 = new global::Gtk.Frame ();
		this.frame6.Name = "frame6";
		this.frame6.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame6.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.vbox11 = new global::Gtk.VBox ();
		this.vbox11.Name = "vbox11";
		this.vbox11.Spacing = 6;
		// Container child vbox11.Gtk.Box+BoxChild
		this.proxyCheckButton = new global::Gtk.CheckButton ();
		this.proxyCheckButton.CanFocus = true;
		this.proxyCheckButton.Name = "proxyCheckButton";
		this.proxyCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Use Proxy");
		this.proxyCheckButton.DrawIndicator = true;
		this.proxyCheckButton.UseUnderline = true;
		this.vbox11.Add (this.proxyCheckButton);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.proxyCheckButton]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox11.Gtk.Box+BoxChild
		this.proxyUrlTextView = new global::Gtk.TextView ();
		this.proxyUrlTextView.Sensitive = false;
		this.proxyUrlTextView.CanFocus = true;
		this.proxyUrlTextView.Name = "proxyUrlTextView";
		this.vbox11.Add (this.proxyUrlTextView);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.proxyUrlTextView]));
		w11.Position = 1;
		// Container child vbox11.Gtk.Box+BoxChild
		this.socketTimeoutCheckButton = new global::Gtk.CheckButton ();
		this.socketTimeoutCheckButton.CanFocus = true;
		this.socketTimeoutCheckButton.Name = "socketTimeoutCheckButton";
		this.socketTimeoutCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Enable socket timeout");
		this.socketTimeoutCheckButton.DrawIndicator = true;
		this.socketTimeoutCheckButton.UseUnderline = true;
		this.vbox11.Add (this.socketTimeoutCheckButton);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.socketTimeoutCheckButton]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox11.Gtk.Box+BoxChild
		this.socketTimeoutTextView = new global::Gtk.TextView ();
		this.socketTimeoutTextView.Sensitive = false;
		this.socketTimeoutTextView.CanFocus = true;
		this.socketTimeoutTextView.Name = "socketTimeoutTextView";
		this.vbox11.Add (this.socketTimeoutTextView);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.socketTimeoutTextView]));
		w13.Position = 3;
		this.GtkAlignment2.Add (this.vbox11);
		this.frame6.Add (this.GtkAlignment2);
		this.GtkLabel6 = new global::Gtk.Label ();
		this.GtkLabel6.Name = "GtkLabel6";
		this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Network Options</b>");
		this.GtkLabel6.UseMarkup = true;
		this.frame6.LabelWidget = this.GtkLabel6;
		this.hbox2.Add (this.frame6);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame6]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w17.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		this.vbox1.Add (this.hbox4);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
		w18.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.button16 = new global::Gtk.Button ();
		this.button16.CanFocus = true;
		this.button16.Name = "button16";
		this.button16.UseUnderline = true;
		this.button16.Label = global::Mono.Unix.Catalog.GetString ("Download");
		this.vbox1.Add (this.button16);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.button16]));
		w19.Position = 3;
		w19.Expand = false;
		w19.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.proxyCheckButton.Toggled += new global::System.EventHandler (this.OnProxyCheckButtonToggled);
		this.socketTimeoutCheckButton.Toggled += new global::System.EventHandler (this.OnSocketTimeoutCheckButtonToggled);
	}
}
