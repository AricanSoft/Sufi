using CefSharp;
using ElementiumBrowser.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementiumBrowser.Classes.Handlers
{
    public class DownloadHandler : IDownloadHandler
    {

        bool isOpenWhenComplete = false;
        DownloadedItem downloadedItem;
        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            bool _continue = true;
            var downloadDialog = new DownloadDialog(downloadItem.SuggestedFileName, downloadItem.TotalBytes.ToString(), downloadItem.OriginalUrl);
            var dialogResult = downloadDialog.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                isOpenWhenComplete = true;
            }
            else if (dialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                downloadItem.IsCancelled = true;
                callback.Dispose();
                _continue = false;
            }

            if (_continue)
            {

                var fullPath = config_defines.download_location + downloadItem.SuggestedFileName;

                downloadedItem = new DownloadedItem();
                downloadedItem.FileName = downloadItem.SuggestedFileName;
                downloadedItem.FilePath = fullPath;
                downloadedItem.FileURL = downloadItem.OriginalUrl;
                downloadedItem.FileSize = downloadItem.TotalBytes.ToString();
                downloadedItem.CreateDate = DateTime.Now.ToString();
                downloadedItem.IsCompleted = "false";
                downloadedItem.Percent = 0;


                callback.Continue(fullPath, showDialog: false);
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {

            if (downloadedItem != null)
            {
                downloadedItem.Percent = downloadItem.PercentComplete;
            }

            if (downloadItem.IsComplete)
            {
                if (isOpenWhenComplete)
                Process.Start(downloadItem.FullPath);

                downloadedItem.IsCompleted = "true";
                downloadedItem.Insert();
                downloadedItem = null;
            }
        }
    }
}
