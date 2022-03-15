using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;
using ElementiumBrowser.Forms;
using ElementiumBrowser.Classes.Handlers;
using System.Net;
using ElementiumBrowser.Controllers;

namespace ElementiumBrowser.Classes
{
    public class CefConfig
    {

        private ChromiumWebBrowser cefBrowser;

        public TabForm tParent;
        public ResourceController xResourceController;

        public CefConfig(TabForm _Parent, Control parentObject)
        {

            tParent = _Parent;
            xResourceController = new ResourceController();

            //Tarayıcıyı oluştur
            cefBrowser = new ChromiumWebBrowser();
            setEventHandlers();
            parentObject.Controls.Add(cefBrowser);
            cefBrowser.Dock = DockStyle.Fill;

            //Tarayıcı yönlendir
            Navigate(Functions.getHomeURL());

        }

        private void setEventHandlers()
        {
            cefBrowser.AddressChanged += CefBrowser_AddressChanged;
            cefBrowser.TitleChanged += CefBrowser_TitleChanged;
            cefBrowser.LoadingStateChanged += CefBrowser_LoadingStateChanged;

            cefBrowser.MenuHandler = new ContextMenuHandler();
            cefBrowser.DownloadHandler = new DownloadHandler();
        }

        private void CefBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            tParent.setRefreshButtonType(e.Browser.IsLoading);
            tParent.setButtonState(e.Browser.CanGoBack, e.CanGoForward);
            tParent.setTitle("Yükleniyor..");

            if (e.IsLoading != false)
            {
                checkForHistory();
            }
        }

        private void CefBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            tParent.setTitle(e.Title.ToString());
        }

        private void CefBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            tParent.setURL(e.Address);
        }

        public void Navigate(string _url)
        {

            string process_url = _url.ToLower();


            if (process_url.StartsWith(Functions.xaleURLBuilder("")))
            {
                loadResource(_url, xResourceController.loadSchemaUrl(_url));
            }
            else
            {

                if (Functions.checkURL(process_url))
                {
                    cefBrowser.Load(_url);
                }
                else
                {
                    Search(_url);
                }

            }

        }
        public void Search(string searchText)
        {
            cefBrowser.Load(Functions.getSearchEngine() + searchText);
        }

        public void loadResource(string url, string data)
        {
            cefBrowser.LoadHtml(data, url, Encoding.UTF8, true);
        }

        public void checkForHistory()
        {

            string _url = cefBrowser.Address;
            if (!_url.ToLower().StartsWith("sufi://"))
                history.addHistory(_url, DateTime.Now.ToString(), "test");

        }

        public ChromiumWebBrowser getBrowser()
        {
            return cefBrowser;
        }
    }
}
