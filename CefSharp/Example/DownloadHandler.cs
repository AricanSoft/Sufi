namespace CefSharp.Example
{
    using CefSharp;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public class DownloadHandler : IDownloadHandler
    {
        [field: CompilerGenerated, DebuggerBrowsable(0)]
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        [field: CompilerGenerated, DebuggerBrowsable(0)]
        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            if (this.OnBeforeDownloadFired != null)
            {
                EventHandler<DownloadItem> onBeforeDownloadFired = this.OnBeforeDownloadFired;
                onBeforeDownloadFired(this, downloadItem);
            }
            else
            {
                EventHandler<DownloadItem> expressionStack_A_0 = this.OnBeforeDownloadFired;
            }
            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, true);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            if (this.OnDownloadUpdatedFired != null)
            {
                EventHandler<DownloadItem> onDownloadUpdatedFired = this.OnDownloadUpdatedFired;
                onDownloadUpdatedFired(this, downloadItem);
            }
            else
            {
                EventHandler<DownloadItem> expressionStack_A_0 = this.OnDownloadUpdatedFired;
            }
        }
    }
}

