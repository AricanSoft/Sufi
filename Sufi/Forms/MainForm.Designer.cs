using System.Windows.Forms;

namespace ElementiumBrowser.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabcontrol_main = new MdiTabControl.TabControl();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_restore_size = new System.Windows.Forms.Button();
            this.buton_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabcontrol_main
            // 
            this.tabcontrol_main.BackHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tabcontrol_main.BackLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tabcontrol_main.BorderColor = System.Drawing.Color.White;
            this.tabcontrol_main.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tabcontrol_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol_main.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol_main.MenuRenderer = null;
            this.tabcontrol_main.Name = "tabcontrol_main";
            this.tabcontrol_main.Size = new System.Drawing.Size(1025, 631);
            this.tabcontrol_main.TabBackHighColor = System.Drawing.Color.White;
            this.tabcontrol_main.TabBackHighColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tabcontrol_main.TabBackLowColor = System.Drawing.Color.White;
            this.tabcontrol_main.TabBackLowColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tabcontrol_main.TabBorderEnhanced = true;
            this.tabcontrol_main.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft;
            this.tabcontrol_main.TabCloseButtonBackHighColor = System.Drawing.Color.Transparent;
            this.tabcontrol_main.TabCloseButtonBackHighColorDisabled = System.Drawing.Color.Transparent;
            this.tabcontrol_main.TabCloseButtonBackHighColorHot = System.Drawing.Color.WhiteSmoke;
            this.tabcontrol_main.TabCloseButtonBackLowColor = System.Drawing.Color.Transparent;
            this.tabcontrol_main.TabCloseButtonBackLowColorDisabled = System.Drawing.Color.Transparent;
            this.tabcontrol_main.TabCloseButtonBackLowColorHot = System.Drawing.Color.WhiteSmoke;
            this.tabcontrol_main.TabCloseButtonBorderColor = System.Drawing.Color.Transparent;
            this.tabcontrol_main.TabCloseButtonBorderColorDisabled = System.Drawing.Color.Transparent;
            this.tabcontrol_main.TabCloseButtonBorderColorHot = System.Drawing.Color.Transparent;
            this.tabcontrol_main.TabCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.tabcontrol_main.TabCloseButtonForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.tabcontrol_main.TabCloseButtonForeColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.tabcontrol_main.TabCloseButtonImage = null;
            this.tabcontrol_main.TabCloseButtonImageDisabled = null;
            this.tabcontrol_main.TabCloseButtonImageHot = null;
            this.tabcontrol_main.TabCloseButtonSize = new System.Drawing.Size(16, 16);
            this.tabcontrol_main.TabGlassGradient = true;
            this.tabcontrol_main.TabHeight = 32;
            this.tabcontrol_main.TabIndex = 0;
            this.tabcontrol_main.TabMinimumWidth = 200;
            this.tabcontrol_main.TabOffset = 1;
            this.tabcontrol_main.TabPadLeft = 12;
            this.tabcontrol_main.TabPadRight = 12;
            this.tabcontrol_main.TabTop = 0;
            this.tabcontrol_main.TopSeparator = false;
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.button_minimize.BackgroundImage = global::ElementiumBrowser.Properties.Resources.button_minimize;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Location = new System.Drawing.Point(864, 3);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(49, 27);
            this.button_minimize.TabIndex = 65;
            this.button_minimize.UseVisualStyleBackColor = false;
            // 
            // button_restore_size
            // 
            this.button_restore_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_restore_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.button_restore_size.BackgroundImage = global::ElementiumBrowser.Properties.Resources.button_restore_size;
            this.button_restore_size.FlatAppearance.BorderSize = 0;
            this.button_restore_size.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_restore_size.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_restore_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_restore_size.Location = new System.Drawing.Point(919, 3);
            this.button_restore_size.Name = "button_restore_size";
            this.button_restore_size.Size = new System.Drawing.Size(49, 27);
            this.button_restore_size.TabIndex = 64;
            this.button_restore_size.UseVisualStyleBackColor = false;
            // 
            // buton_close
            // 
            this.buton_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buton_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.buton_close.BackgroundImage = global::ElementiumBrowser.Properties.Resources.button_close;
            this.buton_close.FlatAppearance.BorderSize = 0;
            this.buton_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buton_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_close.Location = new System.Drawing.Point(974, 3);
            this.buton_close.Name = "buton_close";
            this.buton_close.Size = new System.Drawing.Size(49, 27);
            this.buton_close.TabIndex = 63;
            this.buton_close.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 631);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_restore_size);
            this.Controls.Add(this.buton_close);
            this.Controls.Add(this.tabcontrol_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "MainForm";
            this.Text = "Sufi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MdiTabControl.TabControl tabcontrol_main;
        internal Button button_minimize;
        internal Button button_restore_size;
        internal Button buton_close;
    }
}