
namespace ElementiumBrowser.Forms
{
    partial class TabForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabForm));
            this.panel_navigation_bar = new System.Windows.Forms.Panel();
            this.button_go_forward = new System.Windows.Forms.Button();
            this.urlbar_left = new System.Windows.Forms.PictureBox();
            this.urlbar_right = new System.Windows.Forms.PictureBox();
            this.buttton_show_settings = new System.Windows.Forms.Button();
            this.panel_urlbox = new System.Windows.Forms.Panel();
            this.rtextbox_urlbox = new System.Windows.Forms.RichTextBox();
            this.button_refresh_close = new System.Windows.Forms.Button();
            this.button_go_back = new System.Windows.Forms.Button();
            this.panel_browser_area = new System.Windows.Forms.Panel();
            this.DefaultMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniSekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçerliSekmeyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.geçmişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indirilenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tarayıcıHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarayıcıdanÇıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_navigation_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlbar_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlbar_right)).BeginInit();
            this.panel_urlbox.SuspendLayout();
            this.DefaultMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_navigation_bar
            // 
            this.panel_navigation_bar.BackColor = System.Drawing.Color.White;
            this.panel_navigation_bar.Controls.Add(this.button_go_forward);
            this.panel_navigation_bar.Controls.Add(this.urlbar_left);
            this.panel_navigation_bar.Controls.Add(this.urlbar_right);
            this.panel_navigation_bar.Controls.Add(this.buttton_show_settings);
            this.panel_navigation_bar.Controls.Add(this.panel_urlbox);
            this.panel_navigation_bar.Controls.Add(this.button_refresh_close);
            this.panel_navigation_bar.Controls.Add(this.button_go_back);
            this.panel_navigation_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_navigation_bar.Location = new System.Drawing.Point(0, 0);
            this.panel_navigation_bar.Name = "panel_navigation_bar";
            this.panel_navigation_bar.Size = new System.Drawing.Size(800, 48);
            this.panel_navigation_bar.TabIndex = 0;
            // 
            // button_go_forward
            // 
            this.button_go_forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_go_forward.BackgroundImage")));
            this.button_go_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_go_forward.FlatAppearance.BorderSize = 0;
            this.button_go_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_go_forward.Location = new System.Drawing.Point(48, 10);
            this.button_go_forward.Name = "button_go_forward";
            this.button_go_forward.Size = new System.Drawing.Size(30, 30);
            this.button_go_forward.TabIndex = 4;
            this.button_go_forward.Click += new System.EventHandler(this.button_go_forward_Click);
            // 
            // urlbar_left
            // 
            this.urlbar_left.BackgroundImage = global::ElementiumBrowser.Properties.Resources.urlbar_left;
            this.urlbar_left.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urlbar_left.Location = new System.Drawing.Point(132, 12);
            this.urlbar_left.Name = "urlbar_left";
            this.urlbar_left.Size = new System.Drawing.Size(28, 28);
            this.urlbar_left.TabIndex = 8;
            this.urlbar_left.TabStop = false;
            // 
            // urlbar_right
            // 
            this.urlbar_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.urlbar_right.BackgroundImage = global::ElementiumBrowser.Properties.Resources.urlbar_right;
            this.urlbar_right.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urlbar_right.Location = new System.Drawing.Point(724, 12);
            this.urlbar_right.Name = "urlbar_right";
            this.urlbar_right.Size = new System.Drawing.Size(28, 28);
            this.urlbar_right.TabIndex = 7;
            this.urlbar_right.TabStop = false;
            // 
            // buttton_show_settings
            // 
            this.buttton_show_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttton_show_settings.BackgroundImage = global::ElementiumBrowser.Properties.Resources.button_menu;
            this.buttton_show_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttton_show_settings.FlatAppearance.BorderSize = 0;
            this.buttton_show_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttton_show_settings.Location = new System.Drawing.Point(758, 10);
            this.buttton_show_settings.Name = "buttton_show_settings";
            this.buttton_show_settings.Size = new System.Drawing.Size(30, 30);
            this.buttton_show_settings.TabIndex = 6;
            this.buttton_show_settings.UseVisualStyleBackColor = true;
            this.buttton_show_settings.Click += new System.EventHandler(this.buttton_show_settings_Click);
            // 
            // panel_urlbox
            // 
            this.panel_urlbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_urlbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.panel_urlbox.Controls.Add(this.rtextbox_urlbox);
            this.panel_urlbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel_urlbox.Location = new System.Drawing.Point(155, 12);
            this.panel_urlbox.Name = "panel_urlbox";
            this.panel_urlbox.Size = new System.Drawing.Size(576, 28);
            this.panel_urlbox.TabIndex = 5;
            // 
            // rtextbox_urlbox
            // 
            this.rtextbox_urlbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtextbox_urlbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.rtextbox_urlbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtextbox_urlbox.DetectUrls = false;
            this.rtextbox_urlbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtextbox_urlbox.Location = new System.Drawing.Point(11, 4);
            this.rtextbox_urlbox.Multiline = false;
            this.rtextbox_urlbox.Name = "rtextbox_urlbox";
            this.rtextbox_urlbox.Size = new System.Drawing.Size(520, 21);
            this.rtextbox_urlbox.TabIndex = 0;
            this.rtextbox_urlbox.Text = "";
            this.rtextbox_urlbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtextbox_urlbox_KeyDown);
            // 
            // button_refresh_close
            // 
            this.button_refresh_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refresh_close.BackgroundImage")));
            this.button_refresh_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh_close.FlatAppearance.BorderSize = 0;
            this.button_refresh_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh_close.Location = new System.Drawing.Point(84, 10);
            this.button_refresh_close.Name = "button_refresh_close";
            this.button_refresh_close.Size = new System.Drawing.Size(30, 30);
            this.button_refresh_close.TabIndex = 3;
            this.button_refresh_close.UseVisualStyleBackColor = true;
            this.button_refresh_close.Click += new System.EventHandler(this.button_refresh_close_Click);
            // 
            // button_go_back
            // 
            this.button_go_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_go_back.BackgroundImage")));
            this.button_go_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_go_back.FlatAppearance.BorderSize = 0;
            this.button_go_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_go_back.Location = new System.Drawing.Point(12, 10);
            this.button_go_back.Name = "button_go_back";
            this.button_go_back.Size = new System.Drawing.Size(30, 30);
            this.button_go_back.TabIndex = 2;
            this.button_go_back.UseVisualStyleBackColor = true;
            this.button_go_back.Click += new System.EventHandler(this.button_go_back_Click);
            // 
            // panel_browser_area
            // 
            this.panel_browser_area.BackColor = System.Drawing.Color.White;
            this.panel_browser_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_browser_area.Location = new System.Drawing.Point(0, 48);
            this.panel_browser_area.Name = "panel_browser_area";
            this.panel_browser_area.Size = new System.Drawing.Size(800, 402);
            this.panel_browser_area.TabIndex = 1;
            // 
            // DefaultMenu
            // 
            this.DefaultMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSekmeToolStripMenuItem,
            this.geçerliSekmeyiKapatToolStripMenuItem,
            this.yeniPencereToolStripMenuItem,
            this.toolStripSeparator1,
            this.geçmişToolStripMenuItem,
            this.indirilenlerToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.toolStripSeparator2,
            this.tarayıcıHakkındaToolStripMenuItem,
            this.tarayıcıdanÇıkToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.DefaultMenu.Name = "DefaultMenu";
            this.DefaultMenu.Size = new System.Drawing.Size(191, 236);
            // 
            // yeniSekmeToolStripMenuItem
            // 
            this.yeniSekmeToolStripMenuItem.Name = "yeniSekmeToolStripMenuItem";
            this.yeniSekmeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.yeniSekmeToolStripMenuItem.Text = "Yeni Sekme";
            this.yeniSekmeToolStripMenuItem.Click += new System.EventHandler(this.yeniSekmeToolStripMenuItem_Click);
            // 
            // geçerliSekmeyiKapatToolStripMenuItem
            // 
            this.geçerliSekmeyiKapatToolStripMenuItem.Name = "geçerliSekmeyiKapatToolStripMenuItem";
            this.geçerliSekmeyiKapatToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.geçerliSekmeyiKapatToolStripMenuItem.Text = "Geçerli Sekmeyi Kapat";
            this.geçerliSekmeyiKapatToolStripMenuItem.Click += new System.EventHandler(this.geçerliSekmeyiKapatToolStripMenuItem_Click);
            // 
            // yeniPencereToolStripMenuItem
            // 
            this.yeniPencereToolStripMenuItem.Name = "yeniPencereToolStripMenuItem";
            this.yeniPencereToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.yeniPencereToolStripMenuItem.Text = "Yeni Pencere";
            this.yeniPencereToolStripMenuItem.Click += new System.EventHandler(this.yeniPencereToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // geçmişToolStripMenuItem
            // 
            this.geçmişToolStripMenuItem.Name = "geçmişToolStripMenuItem";
            this.geçmişToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.geçmişToolStripMenuItem.Text = "Geçmiş";
            this.geçmişToolStripMenuItem.Click += new System.EventHandler(this.geçmişToolStripMenuItem_Click);
            // 
            // indirilenlerToolStripMenuItem
            // 
            this.indirilenlerToolStripMenuItem.Name = "indirilenlerToolStripMenuItem";
            this.indirilenlerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.indirilenlerToolStripMenuItem.Text = "İndirilenler";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // tarayıcıHakkındaToolStripMenuItem
            // 
            this.tarayıcıHakkındaToolStripMenuItem.Name = "tarayıcıHakkındaToolStripMenuItem";
            this.tarayıcıHakkındaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tarayıcıHakkındaToolStripMenuItem.Text = "Tarayıcı Hakkında";
            this.tarayıcıHakkındaToolStripMenuItem.Click += new System.EventHandler(this.tarayıcıHakkındaToolStripMenuItem_Click);
            // 
            // tarayıcıdanÇıkToolStripMenuItem
            // 
            this.tarayıcıdanÇıkToolStripMenuItem.Name = "tarayıcıdanÇıkToolStripMenuItem";
            this.tarayıcıdanÇıkToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tarayıcıdanÇıkToolStripMenuItem.Text = "Tarayıcıdan Çık";
            this.tarayıcıdanÇıkToolStripMenuItem.Click += new System.EventHandler(this.tarayıcıdanÇıkToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // TabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_browser_area);
            this.Controls.Add(this.panel_navigation_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabForm";
            this.Text = "New Page";
            this.Load += new System.EventHandler(this.TabForm_Load);
            this.panel_navigation_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urlbar_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlbar_right)).EndInit();
            this.panel_urlbox.ResumeLayout(false);
            this.DefaultMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_navigation_bar;
        private System.Windows.Forms.Panel panel_browser_area;
        private System.Windows.Forms.Button buttton_show_settings;
        private System.Windows.Forms.Panel panel_urlbox;
        private System.Windows.Forms.Button button_go_forward;
        private System.Windows.Forms.Button button_refresh_close;
        private System.Windows.Forms.Button button_go_back;
        private System.Windows.Forms.RichTextBox rtextbox_urlbox;
        private System.Windows.Forms.ContextMenuStrip DefaultMenu;
        private System.Windows.Forms.ToolStripMenuItem yeniSekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçerliSekmeyiKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniPencereToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem geçmişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indirilenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tarayıcıHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarayıcıdanÇıkToolStripMenuItem;
        private System.Windows.Forms.PictureBox urlbar_right;
        private System.Windows.Forms.PictureBox urlbar_left;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}