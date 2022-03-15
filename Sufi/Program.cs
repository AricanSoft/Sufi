using CefSharp;
using CefSharp.WinForms;
using ElementiumBrowser.Classes;
using ElementiumBrowser.Classes.Handlers;
using ElementiumBrowser.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementiumBrowser
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Dışarıdan gelen komut argümanlarını getir.
            getOutArgs();
            initalizeCefSharp();

            //MainForm'u başlat.
            Application.Run(new MainForm());

        }

        public static void getOutArgs()
        {
            string[] inArgs = Environment.GetCommandLineArgs();
            foreach (string argument in inArgs)
            {
                if (argument == "-debug")
                {
                    Functions.Debug = true;
                }
            }
        }

        public static void initalizeCefSharp()
        {

            //CEF AYARLARINI YÜKLE
            CefSettings cefSettings = new CefSettings();
            cefSettings.UserAgent = Config.userAgent;
            cefSettings.AcceptLanguageList = Config.acceptLanguageList;
            cefSettings.CachePath = Functions.getCachePath();

            cefSettings.RegisterScheme(new CefCustomScheme()
            {

                SchemeName = Config.xaleSchemaName,
                SchemeHandlerFactory = new SchemaHandler(),

            });

            Cef.Initialize(cefSettings);
        }
    }
}
