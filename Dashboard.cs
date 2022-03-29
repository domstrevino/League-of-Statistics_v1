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
    public partial class Dashboard : Form
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
        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void BtnChamps_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnChamps.Height;
            pnlNav.Top = btnChamps.Top;
            btnChamps.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            Champs f3 = new Champs();
            this.Close();
            f3.Show();
        }
        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStatistics.Height;
            pnlNav.Top = btnStatistics.Top;
            btnStatistics.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            btnProfile.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void BtnChamps_Leave(object sender, EventArgs e)
        {
            btnChamps.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void BtnStatistics_Leave(object sender, EventArgs e)
        {
            btnStatistics.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void BtnExit_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 /**   class LeagueScaper : WebScraper
    {
        public override void Init()
        {
            this.LoggingLevel = WebScraper.LogLevel.All;
            this.Request("https://na.op.gg/", Parse);
        }
        public override void Parse(Response response)
        {
            foreach (var title_link in response.Css("h2.entry-title a"))
            {
                string strTitle = title_link.TextContentClean;
                Scrape(new ScrapedData() { { "Title", strTitle } });
            }

            if (response.CssExists("div.prev-post > a[href]"))
            {
                var next_page = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
                this.Request(next_page, Parse);
            }
        }
        static void Main(string[] args)
        {
            var ScrapeJob = new LeagueScaper();
            ScrapeJob.Start();
        }
    } **/
