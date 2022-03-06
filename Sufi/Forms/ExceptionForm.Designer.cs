
namespace ElementiumBrowser.Forms
{
    partial class ExceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionForm));
            this.rtextbox_exceptiontext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtextbox_exceptiontext
            // 
            this.rtextbox_exceptiontext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.rtextbox_exceptiontext.Location = new System.Drawing.Point(12, 12);
            this.rtextbox_exceptiontext.Name = "rtextbox_exceptiontext";
            this.rtextbox_exceptiontext.Size = new System.Drawing.Size(545, 258);
            this.rtextbox_exceptiontext.TabIndex = 0;
            this.rtextbox_exceptiontext.Text = "";
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(569, 282);
            this.Controls.Add(this.rtextbox_exceptiontext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExceptionForm";
            this.Text = "Bir hata oluştu  ";
            this.Load += new System.EventHandler(this.ExceptionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtextbox_exceptiontext;
    }
}