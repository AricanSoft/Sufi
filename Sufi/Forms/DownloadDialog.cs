using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementiumBrowser.Forms
{
    public partial class DownloadDialog : Form
    {
        public DownloadDialog(string file_name,string file_size,string file_url)
        {
            InitializeComponent();

            lbl_ddialog_filename.Text = file_name;
            lbl_ddialog_filesize.Text = file_size;
            lbl_ddialog_fileurl.Text = file_url;
        }

    }
}
