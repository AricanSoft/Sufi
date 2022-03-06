using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using CefSharp;
using CefSharp.WinForms;
using ElementiumBrowser.Classes;
namespace ElementiumBrowser.Forms
{
    public partial class TabForm : Form
    {

        private CefConfig cefConfig;
        private ChromiumWebBrowser workingBrowser;

        public TabForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            cefConfig = new CefConfig(this, panel_browser_area);
            workingBrowser = cefConfig.getBrowser();
        }

        private void TabForm_Load(object sender, EventArgs e)
        {

        }

        public void loadPage(string _URL)
        {
            cefConfig.Navigate(_URL);
        }
        public void showSource()
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                Functions.addTab("view-source:"+cefConfig.getBrowser().Address);
            });
        }
        public void setURL(string _URL)
        {

            Uri _uri = new Uri(_URL);

            string protocol = _URL.Split(new string[] { "://" }, StringSplitOptions.None)[0] + "://";
            _URL = _URL.Replace(protocol, "");

            string domain = _uri.Host;

            string path = "/" + _URL.Split('/')[1];

            rtextbox_urlbox.Clear();

            rtextbox_urlbox.SelectionColor = protocol.Contains("s") ? Color.FromArgb(32, 181, 68) : Color.Gray;
            rtextbox_urlbox.SelectedText = protocol;

            rtextbox_urlbox.SelectionColor = Color.FromArgb(32,33,36);
            rtextbox_urlbox.SelectedText = domain;

            rtextbox_urlbox.SelectionColor = Color.Gray;
            rtextbox_urlbox.SelectedText = path;

        }

        public void setRefreshButtonType(bool isLoading)
        {

            var refreshIcon = Properties.Resources.button_refresh;
            var closeIcon = Properties.Resources.button_stop;

            button_refresh_close.BackgroundImage = isLoading ? closeIcon : refreshIcon;
        }
        public void setButtonState(bool _canGoBack, bool _canGoForward)
        {
            button_go_back.Enabled = _canGoBack;
            button_go_forward.Enabled = _canGoForward;
        }
        public void setTitle(string _title)
        {
            Text = _title;
        }

        private void button_go_back_Click(object sender, EventArgs e)
        {
            if (workingBrowser.CanGoBack)
            {
                workingBrowser.Back();
            }
        }

        private void button_refresh_close_Click(object sender, EventArgs e)
        {
            if (workingBrowser.IsLoading)
            {
                workingBrowser.Stop();
            }
            else
            {
                workingBrowser.Reload();
            }
        }

        private void button_go_forward_Click(object sender, EventArgs e)
        {
            if (workingBrowser.CanGoForward)
            {
                workingBrowser.Forward();
            }
        }

        private void buttton_show_settings_Click(object sender, EventArgs e)
        {
            DefaultMenu.Show(Cursor.Position);
        }

        private void rtextbox_urlbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                cefConfig.Navigate(rtextbox_urlbox.Text);

            }
        }

        private void yeniSekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.addTab();
        }

        private void geçerliSekmeyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.newWindow();
        }

        private void geçmişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPage("sufi://history");
        }

        private void tarayıcıHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tarayıcıdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.applicationSafelyClose();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();

            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://rentry.co/i7sv9/raw").Contains("3.1"))
                {
                    if (MessageBox.Show("Güncelleme var! Şimdi indirilsin mi?", "Sufibyte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        using (var client = new WebClient())
                        {
                            Process.Start("SufiKurucu.exe");
                            this.Close();
                        }
                }
            }
            catch
            {

            }

        }
    }
}
