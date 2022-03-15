using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementiumBrowser.Controllers
{
    public class home
    {
        public static string view()
        {
            List<bool> list = new List<bool>() { false,false };
            return Functions.view("home", "Anasayfa",list);
        }
    }
}
