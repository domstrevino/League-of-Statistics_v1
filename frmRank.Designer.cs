namespace WindowsApplication
{
    partial class frmRank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regionRank = new System.Windows.Forms.Label();
            this.divisionRank = new System.Windows.Forms.Label();
            this.flexRank = new System.Windows.Forms.Label();
            this.summonerLevel = new System.Windows.Forms.Label();
            this.totalGames = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.Label();
            this.RankingsTxtBox = new System.Windows.Forms.GroupBox();
            this.winRate = new System.Windows.Forms.Label();
            this.InformationTxtBox = new System.Windows.Forms.GroupBox();
            this.RankingsTxtBox.SuspendLayout();
            this.InformationTxtBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // regionRank
            // 
            this.regionRank.AutoSize = true;
            this.regionRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regionRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.regionRank.Location = new System.Drawing.Point(6, 19);
            this.regionRank.Name = "regionRank";
            this.regionRank.Size = new System.Drawing.Size(71, 20);
            this.regionRank.TabIndex = 0;
            this.regionRank.Text = "Region:";
            // 
            // divisionRank
            // 
            this.divisionRank.AutoSize = true;
            this.divisionRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divisionRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.divisionRank.Location = new System.Drawing.Point(6, 72);
            this.divisionRank.Name = "divisionRank";
            this.divisionRank.Size = new System.Drawing.Size(88, 20);
            this.divisionRank.TabIndex = 1;
            this.divisionRank.Text = "Solo/Duo:";
            // 
            // flexRank
            // 
            this.flexRank.AutoSize = true;
            this.flexRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flexRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.flexRank.Location = new System.Drawing.Point(6, 125);
            this.flexRank.Name = "flexRank";
            this.flexRank.Size = new System.Drawing.Size(47, 20);
            this.flexRank.TabIndex = 2;
            this.flexRank.Text = "Flex:";
            // 
            // summonerLevel
            // 
            this.summonerLevel.AutoSize = true;
            this.summonerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.summonerLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.summonerLevel.Location = new System.Drawing.Point(6, 19);
            this.summonerLevel.Name = "summonerLevel";
            this.summonerLevel.Size = new System.Drawing.Size(147, 20);
            this.summonerLevel.TabIndex = 3;
            this.summonerLevel.Text = "Summoner Level:";
            // 
            // totalGames
            // 
            this.totalGames.AutoSize = true;
            this.totalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.totalGames.Location = new System.Drawing.Point(6, 70);
            this.totalGames.Name = "totalGames";
            this.totalGames.Size = new System.Drawing.Size(116, 20);
            this.totalGames.TabIndex = 5;
            this.totalGames.Text = "Total Games:";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.AutoSize = true;
            this.NameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NameTxtBox.Location = new System.Drawing.Point(12, 9);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(156, 31);
            this.NameTxtBox.TabIndex = 13;
            this.NameTxtBox.Text = "Username:";
            // 
            // RankingsTxtBox
            // 
            this.RankingsTxtBox.Controls.Add(this.regionRank);
            this.RankingsTxtBox.Controls.Add(this.flexRank);
            this.RankingsTxtBox.Controls.Add(this.divisionRank);
            this.RankingsTxtBox.Location = new System.Drawing.Point(12, 234);
            this.RankingsTxtBox.Name = "RankingsTxtBox";
            this.RankingsTxtBox.Size = new System.Drawing.Size(709, 163);
            this.RankingsTxtBox.TabIndex = 14;
            this.RankingsTxtBox.TabStop = false;
            // 
            // winRate
            // 
            this.winRate.AutoSize = true;
            this.winRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.winRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.winRate.Location = new System.Drawing.Point(6, 126);
            this.winRate.Name = "winRate";
            this.winRate.Size = new System.Drawing.Size(76, 20);
            this.winRate.TabIndex = 15;
            this.winRate.Text = "Winrate:";
            // 
            // InformationTxtBox
            // 
            this.InformationTxtBox.Controls.Add(this.summonerLevel);
            this.InformationTxtBox.Controls.Add(this.winRate);
            this.InformationTxtBox.Controls.Add(this.totalGames);
            this.InformationTxtBox.Location = new System.Drawing.Point(12, 65);
            this.InformationTxtBox.Name = "InformationTxtBox";
            this.InformationTxtBox.Size = new System.Drawing.Size(709, 163);
            this.InformationTxtBox.TabIndex = 16;
            this.InformationTxtBox.TabStop = false;
            // 
            // frmRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.InformationTxtBox);
            this.Controls.Add(this.RankingsTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRank";
            this.Text = "frmRank";
            this.Load += new System.EventHandler(this.FrmRank_Load);
            this.RankingsTxtBox.ResumeLayout(false);
            this.RankingsTxtBox.PerformLayout();
            this.InformationTxtBox.ResumeLayout(false);
            this.InformationTxtBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Label declarations.
        private Label regionRank;
        private Label divisionRank;
        private Label flexRank;
        private Label summonerLevel;
        private Label totalGames;
        private Label winRate;
        private Label NameTxtBox;

        //Groupbox declarations.
        private GroupBox RankingsTxtBox;
        private GroupBox InformationTxtBox;
    }
}