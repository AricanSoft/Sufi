using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElementiumBrowser.Forms;
namespace ElementiumBrowser
{
    public static class ExceptionBase
    {

        public static void showExceptionMessage(string _error_message)
        {
            ExceptionForm exceptionForm = new ExceptionForm(_error_message);
            exceptionForm.Show();
        }

    }
}
