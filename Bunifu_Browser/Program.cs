namespace Bunifu_Browser
{
    using EasyTabs;
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                AppContainer parent = new AppContainer();
                TitleBarTab item = new TitleBarTab(parent);
                frmBrowser browser1 = new frmBrowser {
                    Text = "Sufi - Yeni Sekme"
                };
                item.Content = browser1;
                parent.Tabs.Add(item);
                parent.SelectedTabIndex = 0;
                TitleBarTabsApplicationContext context = new TitleBarTabsApplicationContext();
                context.Start(parent);
                Application.Run(context);
            }
            catch
            {
                MessageBox.Show("Sufi Bir Sorunla Karşılaştı!", "Sufi");
                Environment.Exit(1);
            }
        }
    }
}

