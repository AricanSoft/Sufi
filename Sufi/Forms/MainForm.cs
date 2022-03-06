using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElementiumBrowser.Controllers;
using MdiTabControl;
namespace ElementiumBrowser.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initalizeRegion();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateTab();
        }


        public MdiTabControl.TabControl returnTabObject()
        {

            return tabcontrol_main;

        }

        public void CreateTab(string _URL = "")
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                Functions.addTab(_URL);
            });
       
        }

        #region "Hareket ve düğmeler"

        private void initalizeRegion()
        {
            setMovement();
            setControlButton();
            setResizeComponents(this);
        }

        bool Tutus;
        int FareX, FareY;

        public void setMovement()
        {
            tabcontrol_main.pnlTabs.MouseMove += PnlTabs_MouseMove;
            tabcontrol_main.pnlTabs.MouseUp += PnlTabs_MouseUp;
            tabcontrol_main.pnlTabs.MouseDown += PnlTabs_MouseDown;

            tabcontrol_main.pnlTabs.DoubleClick += PnlTabs_DoubleClick;
        }

        private void PnlTabs_DoubleClick(object sender, EventArgs e)
        {
            restoreSize();
        }

        private void PnlTabs_MouseDown(object sender, MouseEventArgs e)
        {
            Tutus = true;
            FareX = Cursor.Position.X - Left;
            FareY = Cursor.Position.Y - Top;
        }

        private void PnlTabs_MouseUp(object sender, MouseEventArgs e)
        {
            Tutus = false;
        }

        private void PnlTabs_MouseMove(object sender, MouseEventArgs e)
        {
            if (Tutus)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }

                Left = Cursor.Position.X - FareX;
                Top = Cursor.Position.Y - FareY;
            }
        }

        public void setControlButton()
        {
            buton_close.Click += Buton_close_Click;
            button_restore_size.Click += Button_restore_size_Click;
            button_minimize.Click += Button_minimize_Click;
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Button_restore_size_Click(object sender, EventArgs e)
        {
            restoreSize();
        }

        private void Buton_close_Click(object sender, EventArgs e)
        {
            Functions.applicationSafelyClose();
        }

        private void restoreSize()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        #endregion
        #region "Boyutlandırma"

        Panel ustP = new Panel() { Dock = DockStyle.Top, Height = 3, Cursor = Cursors.SizeNS },
              altP = new Panel() { Dock = DockStyle.Bottom, Height = 3, Cursor = Cursors.SizeNS },
              sagP = new Panel() { Dock = DockStyle.Right, Width = 3, Cursor = Cursors.SizeWE },
              solP = new Panel() { Dock = DockStyle.Left, Width = 3, Cursor = Cursors.SizeWE };

        List<Panel> resizePanels = new List<Panel>();

        int resizePanelSize = 3;
        Color resizepanelColor = Color.WhiteSmoke;

        private void setResizeComponents(Form controlobject)
        {

            resizePanels.Add(ustP);
            resizePanels.Add(altP);
            resizePanels.Add(sagP);
            resizePanels.Add(solP);

           foreach (Panel rePanel in resizePanels)
            {
                controlobject.Controls.Add(rePanel);

            }

            ustP.MouseMove += UstP_MouseMove;
            altP.MouseMove += AltP_MouseMove;
            sagP.MouseMove += SagP_MouseMove;
            solP.MouseMove += SolP_MouseMove;

        }


        private void UstP_MouseMove(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Left)
            {
                Size = new Size(Size.Width, Size.Height +(Location.Y - MousePosition.Y));
                Location = new Point(Location.X, MousePosition.Y);
            }
        }
        private void AltP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Size = new Size(Size.Width,MousePosition.Y - Location.Y);
            }
        }


        private void SolP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Size = new Size(Size.Width + (Location.X - MousePosition.X), Size.Height);
                Location = new Point(MousePosition.X, Location.Y);
            }
        }

        private void SagP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Size = new Size((MousePosition.X - Location.X), Size.Height);
            }
        }

        #endregion
    }
}
