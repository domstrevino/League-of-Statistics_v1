using System.Runtime.InteropServices;

namespace WindowsApplication
{
    public partial class formHome : Form
    {
        //Imports dll to create the round rectangle shape of the application.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
        //Creates a round rectangle for the formHome windows form application.
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public formHome()
        {
            InitializeComponent();

            //Sets the windows form application to a round rectangle.
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //Formats the dashboard button in the panel navigation.
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            //Opens the dashboard form into the forms panel.
            FormLabel.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard Dashboard = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Dashboard.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Dashboard);
            Dashboard.Show();
        }


        //Load Dashboard event.
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Loads the user entered name from the start page into the idLabel textbox.
            IdLabel.Text = formStart.userName;
        }



        /*-------------------------------------->BUTTON CLICK EVENTS<--------------------------------------*/

        //Exit button click event.
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Exit the application.
            Application.Exit();
        }

        //Dashboard button click event.
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //Formats the dashboard button in the panel navigation.
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            //Opens the frmDashboard form into the forms panel.
            FormLabel.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard Dashboard = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Dashboard.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Dashboard);
            Dashboard.Show();
        }

        //Champion List button click event.
        private void BtnChampList_Click(object sender, EventArgs e)
        {
            //Formats the Champs button in the panel navigation.
            PnlNav.Height = BtnChampList.Height;
            PnlNav.Top = BtnChampList.Top;
            PnlNav.Left = BtnChampList.Left;
            BtnChampList.BackColor = Color.FromArgb(46, 51, 73);

            //Opens the frmChampions form into the forms panel.
            FormLabel.Text = "Champion List";
            this.PnlFormLoader.Controls.Clear();
            frmChampions Champs = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Champs.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Champs);
            Champs.Show();
        }

        //Rank button click event.
        private void BtnRank_Click(object sender, EventArgs e)
        {
            //Formats the rank button in the panel navigation.
            PnlNav.Height = BtnRank.Height;
            PnlNav.Top = BtnRank.Top;
            PnlNav.Left = BtnChampList.Left;
            BtnRank.BackColor = Color.FromArgb(46, 51, 73);

            //Opens the frmRank form into the forms panel.
            FormLabel.Text = "Rank";
            this.PnlFormLoader.Controls.Clear();
            frmRank Rank = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Rank.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Rank);
            Rank.Show();
        }

        /*-------------------------------------->END BUTTON CLICK EVENTS<--------------------------------------*/
        // 
        //
        //
        /*-------------------------------------->BUTTON LEAVE EVENTS<--------------------------------------*/

        //Dashboard button leave event.
        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            //Changes dashboard button color
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Champion List button leave event.
        private void BtnChampList_Leave(object sender, EventArgs e)
        {
            //Changes champion list button color
            BtnChampList.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Rank button leave event.
        private void BtnRank_Leave(object sender, EventArgs e)
        {
            //Changes rank button color.
            BtnRank.BackColor = Color.FromArgb(24, 30, 54);
        }

        //ID picture click event.
        private void UserPicture_Click(object sender, EventArgs e)
        {
            //Opens the frmDashboard form into the forms panel.
            FormLabel.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard Dashboard = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Dashboard.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Dashboard);
            Dashboard.Show();
        }

        /*-------------------------------------->END BUTTON LEAVE EVENTS<--------------------------------------*/
    }
}
