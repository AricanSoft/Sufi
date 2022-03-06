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
    public partial class ExceptionForm : Form
    {
        public ExceptionForm(string _exception_text)
        {
            InitializeComponent();
        }

        private void ExceptionForm_Load(object sender, EventArgs e)
        {

        }

        public void setErrorMessage(string _exception_text)
        {
            rtextbox_exceptiontext.Text = _exception_text;
        }
    }
}
