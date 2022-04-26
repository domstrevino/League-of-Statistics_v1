namespace WindowsApplication
{
    partial class formHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlNav = new System.Windows.Forms.Panel();
            this.PnlUserInfo = new System.Windows.Forms.Panel();
            this.IdLabel = new System.Windows.Forms.Label();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnChampList = new System.Windows.Forms.Button();
            this.BtnRank = new System.Windows.Forms.Button();
            this.PnlNavBar = new System.Windows.Forms.Panel();
            this.FormLabel = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.PnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.PnlNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 3;
            // 
            // PnlUserInfo
            // 
            this.PnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlUserInfo.Controls.Add(this.IdLabel);
            this.PnlUserInfo.Controls.Add(this.UserPicture);
            this.PnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.PnlUserInfo.Name = "PnlUserInfo";
            this.PnlUserInfo.Size = new System.Drawing.Size(186, 155);
            this.PnlUserInfo.TabIndex = 0;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.IdLabel.Location = new System.Drawing.Point(54, 99);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(74, 16);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "LeagueID";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::WindowsApplication.Properties.Resources.LeagueIcon;
            this.UserPicture.Location = new System.Drawing.Point(0, 0);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(186, 85);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicture.TabIndex = 0;
            this.UserPicture.TabStop = false;
            this.UserPicture.Click += new System.EventHandler(this.UserPicture_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnDashboard.Location = new System.Drawing.Point(0, 155);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(186, 42);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.BtnDashboard.Leave += new System.EventHandler(this.BtnDashboard_Leave);
            // 
            // BtnChampList
            // 
            this.BtnChampList.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnChampList.FlatAppearance.BorderSize = 0;
            this.BtnChampList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChampList.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnChampList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnChampList.Location = new System.Drawing.Point(0, 197);
            this.BtnChampList.Name = "BtnChampList";
            this.BtnChampList.Size = new System.Drawing.Size(186, 42);
            this.BtnChampList.TabIndex = 1;
            this.BtnChampList.Text = "Champion List";
            this.BtnChampList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnChampList.UseVisualStyleBackColor = true;
            this.BtnChampList.Click += new System.EventHandler(this.BtnChampList_Click);
            this.BtnChampList.Leave += new System.EventHandler(this.BtnChampList_Leave);
            // 
            // BtnRank
            // 
            this.BtnRank.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRank.FlatAppearance.BorderSize = 0;
            this.BtnRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRank.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnRank.Location = new System.Drawing.Point(0, 239);
            this.BtnRank.Name = "BtnRank";
            this.BtnRank.Size = new System.Drawing.Size(186, 42);
            this.BtnRank.TabIndex = 1;
            this.BtnRank.Text = "Rank";
            this.BtnRank.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRank.UseVisualStyleBackColor = true;
            this.BtnRank.Click += new System.EventHandler(this.BtnRank_Click);
            this.BtnRank.Leave += new System.EventHandler(this.BtnRank_Leave);
            // 
            // PnlNavBar
            // 
            this.PnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlNavBar.Controls.Add(this.BtnRank);
            this.PnlNavBar.Controls.Add(this.BtnChampList);
            this.PnlNavBar.Controls.Add(this.BtnDashboard);
            this.PnlNavBar.Controls.Add(this.PnlUserInfo);
            this.PnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.PnlNavBar.Name = "PnlNavBar";
            this.PnlNavBar.Size = new System.Drawing.Size(186, 577);
            this.PnlNavBar.TabIndex = 0;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FormLabel.Location = new System.Drawing.Point(192, 9);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(162, 32);
            this.FormLabel.TabIndex = 4;
            this.FormLabel.Text = "Dashboard";
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(914, 9);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(25, 25);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(186, 100);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(765, 477);
            this.PnlFormLoader.TabIndex = 7;
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.PnlNavBar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formHome";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PnlUserInfo.ResumeLayout(false);
            this.PnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.PnlNavBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Button declarations.
        private Button BtnExit;
        private Button BtnDashboard;
        private Button BtnChampList;
        private Button BtnRank;

        //Panel declarations.
        private Panel PnlFormLoader;
        private Panel PnlNav;
        private Panel PnlNavBar;
        private Panel PnlUserInfo;

        //Label declarations.
        private Label IdLabel;
        private Label FormLabel;

        //Picturebox declaration.
        private PictureBox UserPicture;
    }
}