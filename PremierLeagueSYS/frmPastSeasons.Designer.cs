namespace PremierLeagueSYS
{
    partial class frmPastSeasons
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFixturesResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateFixtures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleFixtures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnterResult = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateLeagueTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveTeamBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveTeamExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSelectSeason = new System.Windows.Forms.ComboBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lblSelectSeason = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTeams,
            this.mnuFixturesResults,
            this.mnuBackExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTeams
            // 
            this.mnuTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddTeam,
            this.mnuRemoveTeam,
            this.mnuEditTeam,
            this.mnuGenerateProfile});
            this.mnuTeams.Name = "mnuTeams";
            this.mnuTeams.Size = new System.Drawing.Size(52, 20);
            this.mnuTeams.Text = "Teams";
            // 
            // mnuAddTeam
            // 
            this.mnuAddTeam.Name = "mnuAddTeam";
            this.mnuAddTeam.Size = new System.Drawing.Size(189, 22);
            this.mnuAddTeam.Text = "Add Team";
            // 
            // mnuRemoveTeam
            // 
            this.mnuRemoveTeam.Name = "mnuRemoveTeam";
            this.mnuRemoveTeam.Size = new System.Drawing.Size(189, 22);
            this.mnuRemoveTeam.Text = "Remove Team";
            // 
            // mnuEditTeam
            // 
            this.mnuEditTeam.Name = "mnuEditTeam";
            this.mnuEditTeam.Size = new System.Drawing.Size(189, 22);
            this.mnuEditTeam.Text = "Edit Team";
            // 
            // mnuGenerateProfile
            // 
            this.mnuGenerateProfile.Name = "mnuGenerateProfile";
            this.mnuGenerateProfile.Size = new System.Drawing.Size(189, 22);
            this.mnuGenerateProfile.Text = "Generate Team Profile";
            // 
            // mnuFixturesResults
            // 
            this.mnuFixturesResults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateFixtures,
            this.mnuScheduleFixtures,
            this.mnuEnterResult,
            this.mnuGenerateLeagueTable});
            this.mnuFixturesResults.Name = "mnuFixturesResults";
            this.mnuFixturesResults.Size = new System.Drawing.Size(111, 20);
            this.mnuFixturesResults.Text = "Fixtures + Results";
            // 
            // mnuGenerateFixtures
            // 
            this.mnuGenerateFixtures.Name = "mnuGenerateFixtures";
            this.mnuGenerateFixtures.Size = new System.Drawing.Size(192, 22);
            this.mnuGenerateFixtures.Text = "Generate Fixtures";
            // 
            // mnuScheduleFixtures
            // 
            this.mnuScheduleFixtures.Name = "mnuScheduleFixtures";
            this.mnuScheduleFixtures.Size = new System.Drawing.Size(192, 22);
            this.mnuScheduleFixtures.Text = "Schedule Fixture";
            // 
            // mnuEnterResult
            // 
            this.mnuEnterResult.Name = "mnuEnterResult";
            this.mnuEnterResult.Size = new System.Drawing.Size(192, 22);
            this.mnuEnterResult.Text = "Enter Result";
            // 
            // mnuGenerateLeagueTable
            // 
            this.mnuGenerateLeagueTable.Name = "mnuGenerateLeagueTable";
            this.mnuGenerateLeagueTable.Size = new System.Drawing.Size(192, 22);
            this.mnuGenerateLeagueTable.Text = "Generate League Table";
            // 
            // mnuBackExit
            // 
            this.mnuBackExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBackExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRemoveTeamBack,
            this.mnuRemoveTeamExit});
            this.mnuBackExit.Name = "mnuBackExit";
            this.mnuBackExit.Size = new System.Drawing.Size(68, 20);
            this.mnuBackExit.Text = "Back/Exit";
            // 
            // mnuRemoveTeamBack
            // 
            this.mnuRemoveTeamBack.Name = "mnuRemoveTeamBack";
            this.mnuRemoveTeamBack.Size = new System.Drawing.Size(99, 22);
            this.mnuRemoveTeamBack.Text = "Back";
            this.mnuRemoveTeamBack.Click += new System.EventHandler(this.mnuRemoveTeamBack_Click);
            // 
            // mnuRemoveTeamExit
            // 
            this.mnuRemoveTeamExit.Name = "mnuRemoveTeamExit";
            this.mnuRemoveTeamExit.Size = new System.Drawing.Size(99, 22);
            this.mnuRemoveTeamExit.Text = "Exit";
            this.mnuRemoveTeamExit.Click += new System.EventHandler(this.mnuRemoveTeamExit_Click);
            // 
            // cboSelectSeason
            // 
            this.cboSelectSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectSeason.DropDownWidth = 250;
            this.cboSelectSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectSeason.FormattingEnabled = true;
            this.cboSelectSeason.Location = new System.Drawing.Point(329, 75);
            this.cboSelectSeason.Name = "cboSelectSeason";
            this.cboSelectSeason.Size = new System.Drawing.Size(249, 26);
            this.cboSelectSeason.TabIndex = 22;
            this.cboSelectSeason.SelectedIndexChanged += new System.EventHandler(this.cboSelectSeason_SelectedIndexChanged);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(61, 132);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(681, 295);
            this.dgvTable.TabIndex = 23;
            this.dgvTable.Visible = false;
            // 
            // lblSelectSeason
            // 
            this.lblSelectSeason.AutoSize = true;
            this.lblSelectSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSeason.Location = new System.Drawing.Point(184, 77);
            this.lblSelectSeason.Name = "lblSelectSeason";
            this.lblSelectSeason.Size = new System.Drawing.Size(136, 24);
            this.lblSelectSeason.TabIndex = 24;
            this.lblSelectSeason.Text = "Select Season:";
            // 
            // frmPastSeasons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectSeason);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.cboSelectSeason);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPastSeasons";
            this.Text = "PremierLeagueSYS - Past Seasons";
            this.Load += new System.EventHandler(this.frmPastSeasons_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTeams;
        private System.Windows.Forms.ToolStripMenuItem mnuAddTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuEditTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuFixturesResults;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateFixtures;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleFixtures;
        private System.Windows.Forms.ToolStripMenuItem mnuEnterResult;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateLeagueTable;
        private System.Windows.Forms.ToolStripMenuItem mnuBackExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveTeamBack;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveTeamExit;
        private System.Windows.Forms.ComboBox cboSelectSeason;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label lblSelectSeason;
    }
}