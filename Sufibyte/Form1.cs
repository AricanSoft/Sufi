using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace Sufibyte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\Sufi.exe");
                client.DownloadFile("https://github.com/AricanSoft/Sufi/releases/download/Sufi/Sufi.zip", @"Sufi.zip");
                string zipPath = @".\Sufi.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\Sufi.zip");
                Process.Start(@".\SufiKurucu.exe");
                this.Close();
            }
            catch
            {
                Process.Start("Demo.exe");
                this.Close();
            }

        }
    }
}
