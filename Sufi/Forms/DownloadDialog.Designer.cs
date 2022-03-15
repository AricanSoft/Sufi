namespace ElementiumBrowser.Forms
{
    partial class DownloadDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadDialog));
            this.lbl_ddialog_title = new System.Windows.Forms.Label();
            this.pnl_ddialog_fileinfo = new System.Windows.Forms.Panel();
            this.lbl_ddialog_filesize = new System.Windows.Forms.Label();
            this.lbl_ddialog_filename = new System.Windows.Forms.Label();
            this.pb_ddialog_fileicon = new System.Windows.Forms.PictureBox();
            this.lbl_ddialog_fileurl = new System.Windows.Forms.Label();
            this.lbl_ddialog_question = new System.Windows.Forms.Label();
            this.btn_ddialog_saveandopen = new System.Windows.Forms.Button();
            this.btn_ddialog_save = new System.Windows.Forms.Button();
            this.btn_ddialog_cancel = new System.Windows.Forms.Button();
            this.pnl_ddialog_fileinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ddialog_fileicon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ddialog_title
            // 
            this.lbl_ddialog_title.AutoSize = true;
            this.lbl_ddialog_title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ddialog_title.Location = new System.Drawing.Point(12, 17);
            this.lbl_ddialog_title.Name = "lbl_ddialog_title";
            this.lbl_ddialog_title.Size = new System.Drawing.Size(133, 17);
            this.lbl_ddialog_title.TabIndex = 0;
            this.lbl_ddialog_title.Text = "Dosya indirme işlemi";
            // 
            // pnl_ddialog_fileinfo
            // 
            this.pnl_ddialog_fileinfo.Controls.Add(this.lbl_ddialog_filesize);
            this.pnl_ddialog_fileinfo.Controls.Add(this.lbl_ddialog_filename);
            this.pnl_ddialog_fileinfo.Controls.Add(this.pb_ddialog_fileicon);
            this.pnl_ddialog_fileinfo.Location = new System.Drawing.Point(12, 50);
            this.pnl_ddialog_fileinfo.Name = "pnl_ddialog_fileinfo";
            this.pnl_ddialog_fileinfo.Size = new System.Drawing.Size(360, 47);
            this.pnl_ddialog_fileinfo.TabIndex = 1;
            // 
            // lbl_ddialog_filesize
            // 
            this.lbl_ddialog_filesize.AutoSize = true;
            this.lbl_ddialog_filesize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ddialog_filesize.Location = new System.Drawing.Point(63, 23);
            this.lbl_ddialog_filesize.Name = "lbl_ddialog_filesize";
            this.lbl_ddialog_filesize.Size = new System.Drawing.Size(80, 15);
            this.lbl_ddialog_filesize.TabIndex = 3;
            this.lbl_ddialog_filesize.Text = "Dosya Boyutu";
            // 
            // lbl_ddialog_filename
            // 
            this.lbl_ddialog_filename.AutoSize = true;
            this.lbl_ddialog_filename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ddialog_filename.Location = new System.Drawing.Point(63, 6);
            this.lbl_ddialog_filename.Name = "lbl_ddialog_filename";
            this.lbl_ddialog_filename.Size = new System.Drawing.Size(64, 15);
            this.lbl_ddialog_filename.TabIndex = 2;
            this.lbl_ddialog_filename.Text = "Dosya İsmi";
            // 
            // pb_ddialog_fileicon
            // 
            this.pb_ddialog_fileicon.BackgroundImage = global::ElementiumBrowser.Properties.Resources.file;
            this.pb_ddialog_fileicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ddialog_fileicon.Location = new System.Drawing.Point(17, 4);
            this.pb_ddialog_fileicon.Name = "pb_ddialog_fileicon";
            this.pb_ddialog_fileicon.Size = new System.Drawing.Size(40, 40);
            this.pb_ddialog_fileicon.TabIndex = 0;
            this.pb_ddialog_fileicon.TabStop = false;
            // 
            // lbl_ddialog_fileurl
            // 
            this.lbl_ddialog_fileurl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ddialog_fileurl.Location = new System.Drawing.Point(12, 122);
            this.lbl_ddialog_fileurl.Name = "lbl_ddialog_fileurl";
            this.lbl_ddialog_fileurl.Size = new System.Drawing.Size(376, 27);
            this.lbl_ddialog_fileurl.TabIndex = 4;
            this.lbl_ddialog_fileurl.Text = "İndirilen Dosyanın url\'si";
            this.lbl_ddialog_fileurl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ddialog_question
            // 
            this.lbl_ddialog_question.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ddialog_question.Location = new System.Drawing.Point(121, 208);
            this.lbl_ddialog_question.Name = "lbl_ddialog_question";
            this.lbl_ddialog_question.Size = new System.Drawing.Size(434, 53);
            this.lbl_ddialog_question.TabIndex = 5;
            this.lbl_ddialog_question.Text = "İndirme işlemini onaylıyor musunuz?\r\n";
            this.lbl_ddialog_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ddialog_saveandopen
            // 
            this.btn_ddialog_saveandopen.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_ddialog_saveandopen.Location = new System.Drawing.Point(575, 48);
            this.btn_ddialog_saveandopen.Name = "btn_ddialog_saveandopen";
            this.btn_ddialog_saveandopen.Size = new System.Drawing.Size(94, 23);
            this.btn_ddialog_saveandopen.TabIndex = 6;
            this.btn_ddialog_saveandopen.Text = "İndir ve aç";
            this.btn_ddialog_saveandopen.UseVisualStyleBackColor = true;
            // 
            // btn_ddialog_save
            // 
            this.btn_ddialog_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ddialog_save.Location = new System.Drawing.Point(594, 93);
            this.btn_ddialog_save.Name = "btn_ddialog_save";
            this.btn_ddialog_save.Size = new System.Drawing.Size(75, 23);
            this.btn_ddialog_save.TabIndex = 7;
            this.btn_ddialog_save.Text = "İndir";
            this.btn_ddialog_save.UseVisualStyleBackColor = true;
            // 
            // btn_ddialog_cancel
            // 
            this.btn_ddialog_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ddialog_cancel.Location = new System.Drawing.Point(594, 142);
            this.btn_ddialog_cancel.Name = "btn_ddialog_cancel";
            this.btn_ddialog_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_ddialog_cancel.TabIndex = 8;
            this.btn_ddialog_cancel.Text = "İptal";
            this.btn_ddialog_cancel.UseVisualStyleBackColor = true;
            // 
            // DownloadDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 286);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ddialog_cancel);
            this.Controls.Add(this.btn_ddialog_save);
            this.Controls.Add(this.btn_ddialog_saveandopen);
            this.Controls.Add(this.lbl_ddialog_question);
            this.Controls.Add(this.lbl_ddialog_fileurl);
            this.Controls.Add(this.pnl_ddialog_fileinfo);
            this.Controls.Add(this.lbl_ddialog_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadDialog";
            this.ShowInTaskbar = false;
            this.Text = "Bekleyen indirme işlemi";
            this.pnl_ddialog_fileinfo.ResumeLayout(false);
            this.pnl_ddialog_fileinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ddialog_fileicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ddialog_title;
        private System.Windows.Forms.Panel pnl_ddialog_fileinfo;
        private System.Windows.Forms.Label lbl_ddialog_filename;
        private System.Windows.Forms.PictureBox pb_ddialog_fileicon;
        private System.Windows.Forms.Label lbl_ddialog_filesize;
        private System.Windows.Forms.Label lbl_ddialog_fileurl;
        private System.Windows.Forms.Label lbl_ddialog_question;
        private System.Windows.Forms.Button btn_ddialog_saveandopen;
        private System.Windows.Forms.Button btn_ddialog_save;
        private System.Windows.Forms.Button btn_ddialog_cancel;
    }
}