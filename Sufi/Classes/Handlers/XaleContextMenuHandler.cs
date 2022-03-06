using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementiumBrowser.Classes.Handlers
{
    class XaleContextMenuHandler : IContextMenuHandler
    {
        public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.Clear();

            if (parameters.LinkUrl == "" && parameters.SourceUrl == "" && parameters.SelectionText == "")
            {
                model.AddItem((CefMenuCommand)100, "Geri");
                model.AddItem((CefMenuCommand)101, "İleri");
                if (browser.IsLoading) { model.AddItem((CefMenuCommand)103, "Dur"); } else { model.AddItem((CefMenuCommand)102, "Yenile"); }
                model.AddSeparator();
                model.AddItem((CefMenuCommand)26506, "Farklı Kaydet");
                model.AddItem((CefMenuCommand)131, "Yazdır");
                model.AddSeparator();
            }

            if (parameters.LinkUrl != "")
            {
                model.AddItem((CefMenuCommand)26501, "Bağlantıyı Aç");
                model.AddItem((CefMenuCommand)26502, "Bağlantıyı Yeni Sekmede Aç");
                model.AddItem((CefMenuCommand)26503, "Bağlantıyı Yeni Pencerede Aç");
                model.AddSeparator();
            }

            if (parameters.SourceUrl != "")
            {
                model.AddItem((CefMenuCommand)26504, "Kaynağı Aç");
                model.AddItem((CefMenuCommand)26505, "Kaynağı Yeni Sekmede Aç");
                model.AddItem((CefMenuCommand)26508, "Kaynak Adresini Kopyala");
                model.AddSeparator();
            }

            if (parameters.SelectionText != "")
            {
                model.AddItem((CefMenuCommand)116, "Tümünü Seç");
                model.AddItem((CefMenuCommand)110, "Geri Al");
                model.AddItem((CefMenuCommand)111, "Yinele");
                model.AddSeparator();
                model.AddItem((CefMenuCommand)112, "Kes");
                model.AddItem((CefMenuCommand)113, "Kopyala");
                model.AddItem((CefMenuCommand)114, "Yapıştır");
                model.AddSeparator();
                model.AddItem((CefMenuCommand)26509, "\""+parameters.SelectionText+ "\" Sözcüğünü Web'de Ara");
                model.AddItem((CefMenuCommand)131, "Yazdır");
                model.AddSeparator();
            }

            model.AddItem((CefMenuCommand)132, "Sayfa Kaynağını Görüntüle");
            model.AddItem((CefMenuCommand)26500, "İncele");
        }

        public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if (commandId == (CefMenuCommand)132)
            {
                Functions.getCurrentForm().showSource();
                return true;
            }
            else if (commandId == (CefMenuCommand)26500)
            {
                browser.GetHost().ShowDevTools();
                return true;
            }
            else if (commandId == (CefMenuCommand)26501)
            {
                Functions.getCurrentForm().loadPage(parameters.LinkUrl);
                return true;
            }
            else if (commandId == (CefMenuCommand)26502)
            {
                Functions.getMainForm().CreateTab(parameters.LinkUrl);
                return true;
            }
            else if (commandId == (CefMenuCommand)26503)
            {
                Functions.getMainForm().CreateTab(parameters.LinkUrl);
                return true;
            }
            else if (commandId == (CefMenuCommand)26504)
            {
                Functions.getCurrentForm().loadPage(parameters.SourceUrl);
                return true;
            }
            else if (commandId == (CefMenuCommand)26505)
            {
                Functions.getMainForm().CreateTab(parameters.SourceUrl);
                return true;
            }
            else if (commandId == (CefMenuCommand)26508)
            {
                Clipboard.SetText(parameters.SourceUrl);
                return false;
            }
            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {
        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
