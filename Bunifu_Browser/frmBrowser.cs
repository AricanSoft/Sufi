namespace Bunifu_Browser
{
    using Bunifu.Framework.UI;
    using Bunifu.UI.WinForms;
    using Bunifu.UI.WinForms.BunifuTextbox;
    using CefSharp;
    using CefSharp.Example;
    using CefSharp.WinForms;
    using EasyTabs;
    using Sufi_Browser.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmBrowser : Form
    {
        private ChromiumWebBrowser browser;
        private BunifuImageButton btnBack;
        private BunifuImageButton btnForward;
        private BunifuImageButton btnHome;
        private BunifuImageButton btnRefresh;
        private BunifuImageButton bunifuImageButton1;
        private BunifuToolTip bunifuToolTip1;
        private IContainer components = null;
        private BunifuImageButton imgRefresh;
        private BunifuImageButton imgSpinner;
        private Panel panel1;
        private BunifuTextBox txtSerachOrUrl;

        public frmBrowser()
        {
            this.InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.browser.CanGoBack)
            {
                this.browser.Back();
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (this.browser.CanGoBack)
            {
                this.browser.Back();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (this.browser.CanGoForward)
            {
                this.browser.Forward();
            }
        }

        private void btnForward_Click_1(object sender, EventArgs e)
        {
            if (this.browser.CanGoForward)
            {
                this.browser.Forward();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.browser.Load("www.google.com.tr");
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.browser.Load("www.google.com.tr");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.browser.Reload(true);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.browser.Reload(true);
            this.browser.Refresh();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.browser.ShowDevTools(null, 0, 0);
            }
            catch
            {
                MessageBox.Show("Sufi Bir Sorunla Karşılaştı!", "Sufi");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components > null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                this.browser = new ChromiumWebBrowser("www.google.com.tr", null);
                this.browser.Load("www.google.com.tr");
                this.panel1.Controls.Add(this.browser);
                DownloadHandler handler = new DownloadHandler();
                this.browser.DownloadHandler = handler;
            }
            catch
            {
                MessageBox.Show("Sufi Başlatma Hatası", "Sufi");
                Environment.Exit(1);
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmBrowser));
            this.bunifuToolTip1 = new BunifuToolTip(this.components);
            this.imgRefresh = new BunifuImageButton();
            this.imgSpinner = new BunifuImageButton();
            this.panel1 = new Panel();
            this.bunifuImageButton1 = new BunifuImageButton();
            this.txtSerachOrUrl = new BunifuTextBox();
            this.btnHome = new BunifuImageButton();
            this.btnRefresh = new BunifuImageButton();
            this.btnForward = new BunifuImageButton();
            this.btnBack = new BunifuImageButton();
            ((ISupportInitialize) this.imgRefresh).BeginInit();
            ((ISupportInitialize) this.imgSpinner).BeginInit();
            ((ISupportInitialize) this.bunifuImageButton1).BeginInit();
            ((ISupportInitialize) this.btnHome).BeginInit();
            ((ISupportInitialize) this.btnRefresh).BeginInit();
            ((ISupportInitialize) this.btnForward).BeginInit();
            ((ISupportInitialize) this.btnBack).BeginInit();
            base.SuspendLayout();
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 0x1388;
            this.bunifuToolTip1.BackColor = SystemColors.Control;
            this.bunifuToolTip1.BorderColor = Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1.0;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new Font("Segoe UI", 9f);
            this.bunifuToolTip1.TextForeColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            this.imgRefresh.Image = (Image) manager.GetObject("imgRefresh.Image");
            this.imgRefresh.ImageActive = null;
            this.imgRefresh.Location = new Point(0x2f, 0x2e0);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Size = new Size(30, 30);
            this.imgRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            this.imgRefresh.TabIndex = 8;
            this.imgRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgRefresh, "Refresh");
            this.bunifuToolTip1.SetToolTipIcon(this.imgRefresh, null);
            this.bunifuToolTip1.SetToolTipTitle(this.imgRefresh, "");
            this.imgRefresh.Visible = false;
            this.imgRefresh.Zoom = 10;
            this.imgSpinner.Image = (Image) manager.GetObject("imgSpinner.Image");
            this.imgSpinner.ImageActive = null;
            this.imgSpinner.Location = new Point(0x53, 0x2e0);
            this.imgSpinner.Name = "imgSpinner";
            this.imgSpinner.Size = new Size(30, 30);
            this.imgSpinner.SizeMode = PictureBoxSizeMode.Zoom;
            this.imgSpinner.TabIndex = 9;
            this.imgSpinner.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgSpinner, "Refresh");
            this.bunifuToolTip1.SetToolTipIcon(this.imgSpinner, null);
            this.bunifuToolTip1.SetToolTipTitle(this.imgSpinner, "");
            this.imgSpinner.Visible = false;
            this.imgSpinner.Zoom = 10;
            this.panel1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.Location = new Point(0, 0x2d);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x468, 0x2f9);
            this.panel1.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            this.bunifuImageButton1.Image = Sufi_Browser.Properties.Resources.icons8_console_64__1_;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new Point(0xb6, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new Size(50, 0x25);
            this.bunifuImageButton1.SizeMode = PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0x10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "Dev Tools");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new EventHandler(this.bunifuImageButton1_Click);
            this.txtSerachOrUrl.AcceptsReturn = false;
            this.txtSerachOrUrl.AcceptsTab = false;
            this.txtSerachOrUrl.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtSerachOrUrl.AnimationSpeed = 220;
            this.txtSerachOrUrl.AutoCompleteMode = AutoCompleteMode.None;
            this.txtSerachOrUrl.AutoCompleteSource = AutoCompleteSource.None;
            this.txtSerachOrUrl.AutoSize = true;
            this.txtSerachOrUrl.BackColor = Color.Transparent;
            this.txtSerachOrUrl.BackgroundImage = (Image) manager.GetObject("txtSerachOrUrl.BackgroundImage");
            this.txtSerachOrUrl.BorderColorActive = Color.DodgerBlue;
            this.txtSerachOrUrl.BorderColorDisabled = Color.FromArgb(0xa1, 0xa1, 0xa1);
            this.txtSerachOrUrl.BorderColorHover = Color.FromArgb(0x69, 0xb5, 0xff);
            this.txtSerachOrUrl.BorderColorIdle = Color.Silver;
            this.txtSerachOrUrl.BorderRadius = 30;
            this.txtSerachOrUrl.BorderThickness = 2;
            this.txtSerachOrUrl.CharacterCasing = CharacterCasing.Normal;
            this.txtSerachOrUrl.Cursor = Cursors.IBeam;
            this.txtSerachOrUrl.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            this.txtSerachOrUrl.DefaultText = "";
            this.txtSerachOrUrl.FillColor = Color.White;
            this.txtSerachOrUrl.HideSelection = true;
            this.txtSerachOrUrl.IconLeft = (Image) manager.GetObject("txtSerachOrUrl.IconLeft");
            this.txtSerachOrUrl.IconLeftCursor = Cursors.IBeam;
            this.txtSerachOrUrl.IconPadding = 10;
            this.txtSerachOrUrl.IconRight = (Image) manager.GetObject("txtSerachOrUrl.IconRight");
            this.txtSerachOrUrl.IconRightCursor = Cursors.IBeam;
            this.txtSerachOrUrl.Lines = new string[0];
            this.txtSerachOrUrl.Location = new Point(0xee, 5);
            this.txtSerachOrUrl.MaxLength = 0x7fff;
            this.txtSerachOrUrl.MinimumSize = new Size(100, 0x23);
            this.txtSerachOrUrl.Modified = false;
            this.txtSerachOrUrl.Multiline = false;
            this.txtSerachOrUrl.Name = "txtSerachOrUrl";
            this.txtSerachOrUrl.PasswordChar = '\0';
            this.txtSerachOrUrl.PlaceholderForeColor = Color.Silver;
            this.txtSerachOrUrl.PlaceholderText = "Bir URL Gir Veya Arama Yap";
            this.txtSerachOrUrl.ReadOnly = false;
            this.txtSerachOrUrl.SelectedText = "";
            this.txtSerachOrUrl.SelectionLength = 0;
            this.txtSerachOrUrl.SelectionStart = 0;
            this.txtSerachOrUrl.ShortcutsEnabled = true;
            this.txtSerachOrUrl.Size = new Size(890, 0x25);
            this.txtSerachOrUrl.Style = BunifuTextBox._Style.Bunifu;
            this.txtSerachOrUrl.TabIndex = 15;
            this.txtSerachOrUrl.TextAlign = HorizontalAlignment.Left;
            this.txtSerachOrUrl.TextMarginLeft = 10;
            this.txtSerachOrUrl.TextMarginTop = 0;
            this.txtSerachOrUrl.TextPlaceholder = "Bir URL Gir Veya Arama Yap";
            this.bunifuToolTip1.SetToolTip(this.txtSerachOrUrl, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtSerachOrUrl, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtSerachOrUrl, "");
            this.txtSerachOrUrl.UseSystemPasswordChar = false;
            this.txtSerachOrUrl.TextChanged += new EventHandler(this.txtSerachOrUrl_TextChanged);
            this.txtSerachOrUrl.KeyUp += new KeyEventHandler(this.txtSerachOrUrl_KeyUp_1);
            this.btnHome.Image = (Image) manager.GetObject("btnHome.Image");
            this.btnHome.ImageActive = null;
            this.btnHome.Location = new Point(0x8a, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new Size(0x26, 0x22);
            this.btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 13;
            this.btnHome.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnHome, "Home");
            this.bunifuToolTip1.SetToolTipIcon(this.btnHome, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnHome, "");
            this.btnHome.Zoom = 10;
            this.btnHome.Click += new EventHandler(this.btnHome_Click_1);
            this.btnRefresh.Image = (Image) manager.GetObject("btnRefresh.Image");
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new Point(0x5e, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(0x26, 0x22);
            this.btnRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnRefresh, "Refresh");
            this.bunifuToolTip1.SetToolTipIcon(this.btnRefresh, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnRefresh, "");
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click_1);
            this.btnForward.Image = (Image) manager.GetObject("btnForward.Image");
            this.btnForward.ImageActive = null;
            this.btnForward.Location = new Point(50, 5);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new Size(0x26, 0x22);
            this.btnForward.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnForward.TabIndex = 12;
            this.btnForward.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "Forward");
            this.bunifuToolTip1.SetToolTipIcon(this.btnForward, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnForward, "");
            this.btnForward.Zoom = 10;
            this.btnForward.Click += new EventHandler(this.btnForward_Click_1);
            this.btnBack.Image = (Image) manager.GetObject("btnBack.Image");
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new Point(6, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(0x26, 0x22);
            this.btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 11;
            this.btnBack.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnBack, "Back");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBack, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnBack, "");
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new EventHandler(this.btnBack_Click_1);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            base.ClientSize = new Size(0x469, 0x327);
            base.Controls.Add(this.bunifuImageButton1);
            base.Controls.Add(this.btnBack);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.imgSpinner);
            base.Controls.Add(this.btnForward);
            base.Controls.Add(this.imgRefresh);
            base.Controls.Add(this.txtSerachOrUrl);
            base.Controls.Add(this.btnRefresh);
            base.Controls.Add(this.btnHome);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmBrowser";
            this.Text = "Sufi Web Tarayıcısı";
            base.Load += new EventHandler(this.frmBrowser_Load);
            ((ISupportInitialize) this.imgRefresh).EndInit();
            ((ISupportInitialize) this.imgSpinner).EndInit();
            ((ISupportInitialize) this.bunifuImageButton1).EndInit();
            ((ISupportInitialize) this.btnHome).EndInit();
            ((ISupportInitialize) this.btnRefresh).EndInit();
            ((ISupportInitialize) this.btnForward).EndInit();
            ((ISupportInitialize) this.btnBack).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void txtSerachOrUrl_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtSerachOrUrl_KeyUp_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (this.txtSerachOrUrl.Text.Trim().Length > 0))
            {
                if (this.txtSerachOrUrl.Text.Contains("."))
                {
                    try
                    {
                        this.browser.Load(this.txtSerachOrUrl.Text);
                        this.Text = this.txtSerachOrUrl.Text;
                    }
                    catch
                    {
                        MessageBox.Show("Sufi Bir Sorunla Karşılaştı!", "Sufi");
                        Environment.Exit(1);
                    }
                }
                else
                {
                    this.browser.Load("https://www.google.com/search?q=" + this.txtSerachOrUrl.Text);
                    this.Text = this.txtSerachOrUrl.Text;
                }
            }
        }

        private void txtSerachOrUrl_TextChanged(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.btnRefresh.Image = this.imgRefresh.Image;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.btnRefresh.Image = this.imgSpinner.Image;
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (base.ParentForm as TitleBarTabs);
            }
        }
    }
}

