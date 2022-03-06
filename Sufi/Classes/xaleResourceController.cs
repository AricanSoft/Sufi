using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ElementiumBrowser.Classes
{
    public class xaleResourceController
    {

        private string[] xaleUrls = { "home", "history" };
        private string action = "";
        private string[] parameters = null;
        public xaleResourceController()
        {
        } 
        public xaleResourceController(string parameter)
        {
           if (parameter.Contains("&")) { 
                var main_function = parameter.Split('&')[0];
                string[] _parameters = parameter.Split('&')[1].Split('&');
            
                List<string> param_list = new List<string>();
                action = main_function;
                foreach (string param in _parameters)
                {
                    param_list.Add(param.Split('=')[1]);
                } 
                parameters = param_list.ToArray();
            }
            else
            {
                action = parameter;
            }
        }

        public string loadSchemaUrl(string schemaURL)
        {

            schemaURL = schemaURL.Remove(0, 7).Replace("/", "");
            schemaURL = schemaURL.Contains("?") ? schemaURL.Split('?')[0] : schemaURL;

            string data = "";

            foreach (string _url in xaleUrls)
                if (_url == schemaURL)
                {
                    data = createView(schemaURL);
                    break;
                }
                else
                    data = createView("404");

            return data;
        }

        public string createView(string schemaURL)
        {
            string html = "";
            Type myClassType = Type.GetType("ElementiumBrowser.Controllers."+schemaURL);
            if (myClassType != null) { 
                MethodInfo method = myClassType.GetMethod(!string.IsNullOrEmpty(action) ? action: "view");
                if (method != null) { 
                    object result = method.Invoke(null, parameters ?? null);
                    html = (string)result;
                }
            }
            return html;
        }



    }
}
