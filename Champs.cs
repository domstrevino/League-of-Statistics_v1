using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsApplication
{
    public partial class Champs : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Champs()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            Dashboard f2 = new Dashboard();
            f2.Show();
        }
        private void btnChamps_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnChamps.Height;
            pnlNav.Top = btnChamps.Top;
            btnChamps.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStatistics.Height;
            pnlNav.Top = btnStatistics.Top;
            btnStatistics.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            btnProfile.BackColor = Color.FromArgb(46, 51, 73);

            this.Close();
            HomeScreen f1 = new HomeScreen();
            f1.Show();
        }
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnChamps_Leave(object sender, EventArgs e)
        {
            btnChamps.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnStatistics_Leave(object sender, EventArgs e)
        {
            btnStatistics.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
