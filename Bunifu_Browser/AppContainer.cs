namespace Bunifu_Browser
{
    using EasyTabs;
    using Sufi_Browser.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class AppContainer : TitleBarTabs
    {
        private IContainer components = null;

        public AppContainer()
        {
            this.InitializeComponent();
            base.AeroPeekEnabled = true;
            base.TabRenderer = new ChromeTabRenderer(this);
            this.Text = "Sufi Web Tarayıcısı";
            base.Icon = Sufi_Browser.Properties.Resources.sufi;
        }

        public override TitleBarTab CreateTab()
        {
            TitleBarTab tab1 = new TitleBarTab(this);
            frmBrowser browser1 = new frmBrowser {
                Text = "Sufi - Yeni Sekme"
            };
            tab1.Content = browser1;
            return tab1;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components > null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(800, 450);
            this.Text = "Form1";
        }
    }
}

