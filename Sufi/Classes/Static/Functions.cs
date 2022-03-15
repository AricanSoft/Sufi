using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElementiumBrowser.Forms;
using ElementiumBrowser.Properties;
using Newtonsoft.Json;

namespace ElementiumBrowser
{

    public static class Functions
    {

        public static bool Debug = false;

        public static MainForm getMainForm()
        {

            foreach (MainForm workingForm in Application.OpenForms)
                return workingForm;

            return null;

        }
        public static TabForm getCurrentForm()
        {
            return (TabForm) getMainForm().returnTabObject().SelectedForm;
        }
        public static void addTab(string _URL = "")
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            TabForm tForm = new TabForm();
            tForm.TopLevel = false;
            tForm.Dock = DockStyle.Fill;

           getMainForm().returnTabObject().TabPages.Add(tForm);
            if (is_set(_URL)) tForm.loadPage(_URL);

        }


        public static string getHomeURL()
        {
            string _homeURL = Properties.Settings.Default.homeURL;
            return _homeURL != "" ? _homeURL : Config.tabDefaultURL;
        }

        public static string getSearchEngine()
        {
            return Properties.Settings.Default.SearchEngineURL;
        }

        public static List<string> getURLProtocols()
        {

            List<string> protocols = new List<string>();
            protocols.Add("http");
            protocols.Add("https");
            protocols.Add("file");
            protocols.Add("ftp");
            protocols.Add("info");
            protocols.Add("info");
            protocols.Add("data");

            return protocols;

        }

        public static bool checkURL(string _url)
        {

            _url = _url.ToLower();

            if (_url.Contains(" ") || _url.Contains("\n")) return false;

            bool isFounded = false;
            bool isValid = false;
            foreach (string protocolNames in getURLProtocols())
            {

                if (_url.StartsWith(protocolNames + "://"))
                {
                    isFounded = true;
                    break;
                }

            }

            if (_url.Contains(".") || _url == "localhost")
            {
                isValid = true;
            }

            if (isFounded && !isValid) return true;
            else if (!isFounded && isValid) return true;
            else if (isFounded && isValid) return true;
            else if (!isFounded && !isValid) return false;

            return false;
        }

        public static void newWindow()
        {
            Process.Start(Application.StartupPath + @"\Sufi.exe");
        }

        public static string getCachePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\ElementiumBrowser";
        }

        public static void applicationSafelyClose()
        {
            try
            {

                Properties.Settings.Default.Save();

                Application.Exit();

            }
            catch (Exception ex)
            {
                ExceptionBase.showExceptionMessage(ex.ToString());

            }
        }

        public static bool is_set(string _value)
        {
            if (_value != null || _value != "" || _value != " ")
                return true;

            return false;
        }

        public static string json_encode(object element)
        {
            return JsonConvert.SerializeObject(element);
        }
        public static object json_decode(string element)
        {
            return JsonConvert.DeserializeObject(element);
        }

        public static string require(string element)
        {
            return Resources.ResourceManager.GetString(element);
        }

        /* 
         page_config = [
         0 = header;
         1 = footer;
        ]
         */
        public static string view (string page, string title,List<bool> page_config = null)
        {
            page_config = page_config ?? new List<bool>() { true,true };

            string returnPage = 
            page_config[0] ? require("page_header") : "";
            returnPage += require("page_"+page);
            returnPage += page_config[1] ? require("page_footer") : "";

           List<string[]> replace_parameters = new List<string[]>() {
               new string[] { "{title}", title },
               new string[] { "{jquery}", require("script_query") },
               new string[] { "{home-page}", getHomeURL() },
               new string[] { "{search-engine}", getSearchEngine() },
               new string[] { "{history-page}", xaleURLBuilder("history") },
           };
            return replace(replace_parameters, returnPage);
        }

        public static string replace(List<string[]> search_replace, string str) {
            string returnVal = str;
            
            foreach (string[] s_str in search_replace)
            {
                    returnVal = returnVal.Replace(s_str[0], s_str[1]);
            }

            return returnVal;
        }

        public static string xaleURLBuilder(string _url)
        {
            return Config.xaleSchemaName + "://" + _url;

        }
    }
}
