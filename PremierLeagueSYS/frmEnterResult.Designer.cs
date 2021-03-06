namespace PremierLeagueSYS
{
    partial class frmEnterResult
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
            this.btnSubmitResult = new System.Windows.Forms.Button();
            this.txtAwayGoals = new System.Windows.Forms.TextBox();
            this.lblAwayGoals = new System.Windows.Forms.Label();
            this.txtHomeGoals = new System.Windows.Forms.TextBox();
            this.lblHomeGoals = new System.Windows.Forms.Label();
            this.btnSelectFixture = new System.Windows.Forms.Button();
            this.cboSelectFixture = new System.Windows.Forms.ComboBox();
            this.lblSelectFixture = new System.Windows.Forms.Label();
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFixtures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateFixtures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleFixtures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReschedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnterResult = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateLeagueTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeasons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewSeason = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPastSeasons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitResult
            // 
            this.btnSubmitResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitResult.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitResult.Location = new System.Drawing.Point(545, 300);
            this.btnSubmitResult.Name = "btnSubmitResult";
            this.btnSubmitResult.Size = new System.Drawing.Size(168, 54);
            this.btnSubmitResult.TabIndex = 29;
            this.btnSubmitResult.Text = "Submit Result";
            this.btnSubmitResult.UseVisualStyleBackColor = true;
            this.btnSubmitResult.Visible = false;
            this.btnSubmitResult.Click += new System.EventHandler(this.btnSubmitResult_Click);
            // 
            // txtAwayGoals
            // 
            this.txtAwayGoals.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAwayGoals.Location = new System.Drawing.Point(251, 327);
            this.txtAwayGoals.MaxLength = 2;
            this.txtAwayGoals.Name = "txtAwayGoals";
            this.txtAwayGoals.Size = new System.Drawing.Size(249, 27);
            this.txtAwayGoals.TabIndex = 28;
            this.txtAwayGoals.Visible = false;
            // 
            // lblAwayGoals
            // 
            this.lblAwayGoals.AutoSize = true;
            this.lblAwayGoals.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwayGoals.Location = new System.Drawing.Point(78, 326);
            this.lblAwayGoals.Name = "lblAwayGoals";
            this.lblAwayGoals.Size = new System.Drawing.Size(113, 25);
            this.lblAwayGoals.TabIndex = 27;
            this.lblAwayGoals.Text = "Away Goals:";
            this.lblAwayGoals.Visible = false;
            // 
            // txtHomeGoals
            // 
            this.txtHomeGoals.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeGoals.Location = new System.Drawing.Point(251, 260);
            this.txtHomeGoals.MaxLength = 2;
            this.txtHomeGoals.Name = "txtHomeGoals";
            this.txtHomeGoals.Size = new System.Drawing.Size(249, 27);
            this.txtHomeGoals.TabIndex = 26;
            this.txtHomeGoals.Visible = false;
            // 
            // lblHomeGoals
            // 
            this.lblHomeGoals.AutoSize = true;
            this.lblHomeGoals.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGoals.Location = new System.Drawing.Point(78, 259);
            this.lblHomeGoals.Name = "lblHomeGoals";
            this.lblHomeGoals.Size = new System.Drawing.Size(118, 25);
            this.lblHomeGoals.TabIndex = 25;
            this.lblHomeGoals.Text = "Home Goals:";
            this.lblHomeGoals.Visible = false;
            // 
            // btnSelectFixture
            // 
            this.btnSelectFixture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFixture.ForeColor = System.Drawing.Color.Black;
            this.btnSelectFixture.Location = new System.Drawing.Point(545, 162);
            this.btnSelectFixture.Name = "btnSelectFixture";
            this.btnSelectFixture.Size = new System.Drawing.Size(168, 54);
            this.btnSelectFixture.TabIndex = 24;
            this.btnSelectFixture.Text = "Select Fixture";
            this.btnSelectFixture.UseVisualStyleBackColor = true;
            this.btnSelectFixture.Click += new System.EventHandler(this.btnSelectFixture_Click);
            // 
            // cboSelectFixture
            // 
            this.cboSelectFixture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectFixture.DropDownWidth = 350;
            this.cboSelectFixture.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectFixture.FormattingEnabled = true;
            this.cboSelectFixture.Location = new System.Drawing.Point(251, 192);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(249, 28);
            this.cboSelectFixture.TabIndex = 23;
            // 
            // lblSelectFixture
            // 
            this.lblSelectFixture.AutoSize = true;
            this.lblSelectFixture.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFixture.Location = new System.Drawing.Point(78, 191);
            this.lblSelectFixture.Name = "lblSelectFixture";
            this.lblSelectFixture.Size = new System.Drawing.Size(128, 25);
            this.lblSelectFixture.TabIndex = 22;
            this.lblSelectFixture.Text = "Select Fixture:";
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectTeam.DropDownWidth = 250;
            this.cboSelectTeam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(251, 122);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(249, 28);
            this.cboSelectTeam.TabIndex = 21;
            this.cboSelectTeam.SelectedValueChanged += new System.EventHandler(this.cboSelectTeam_SelectedValueChanged);
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.Location = new System.Drawing.Point(78, 121);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(115, 25);
            this.lblSelectTeam.TabIndex = 20;
            this.lblSelectTeam.Text = "Select Team:";
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTeams,
            this.mnuFixtures,
            this.mnuSeasons,
            this.mnuBackExit});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(800, 24);
            this.mnuStrip.TabIndex = 33;
            this.mnuStrip.Text = "menuStrip1";
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
            // mnuFixtures
            // 
            this.mnuFixtures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateFixtures,
            this.mnuScheduleFixtures,
            this.mnuReschedule,
            this.mnuEnterResult,
            this.viewResultsToolStripMenuItem,
            this.mnuGenerateLeagueTable});
            this.mnuFixtures.Name = "mnuFixtures";
            this.mnuFixtures.Size = new System.Drawing.Size(111, 20);
            this.mnuFixtures.Text = "Fixtures + Results";
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
            // mnuReschedule
            // 
            this.mnuReschedule.Name = "mnuReschedule";
            this.mnuReschedule.Size = new System.Drawing.Size(192, 22);
            this.mnuReschedule.Text = "Reschedule Fixture";
            // 
            // mnuEnterResult
            // 
            this.mnuEnterResult.Name = "mnuEnterResult";
            this.mnuEnterResult.Size = new System.Drawing.Size(192, 22);
            this.mnuEnterResult.Text = "Enter Result";
            // 
            // viewResultsToolStripMenuItem
            // 
            this.viewResultsToolStripMenuItem.Name = "viewResultsToolStripMenuItem";
            this.viewResultsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewResultsToolStripMenuItem.Text = "View Results";
            // 
            // mnuGenerateLeagueTable
            // 
            this.mnuGenerateLeagueTable.Name = "mnuGenerateLeagueTable";
            this.mnuGenerateLeagueTable.Size = new System.Drawing.Size(192, 22);
            this.mnuGenerateLeagueTable.Text = "Generate League Table";
            // 
            // mnuSeasons
            // 
            this.mnuSeasons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewSeason,
            this.mnuPastSeasons});
            this.mnuSeasons.Name = "mnuSeasons";
            this.mnuSeasons.Size = new System.Drawing.Size(61, 20);
            this.mnuSeasons.Text = "Seasons";
            // 
            // mnuNewSeason
            // 
            this.mnuNewSeason.Name = "mnuNewSeason";
            this.mnuNewSeason.Size = new System.Drawing.Size(169, 22);
            this.mnuNewSeason.Text = "New Season";
            // 
            // mnuPastSeasons
            // 
            this.mnuPastSeasons.Name = "mnuPastSeasons";
            this.mnuPastSeasons.Size = new System.Drawing.Size(169, 22);
            this.mnuPastSeasons.Text = "View Past Seasons";
            // 
            // mnuBackExit
            // 
            this.mnuBackExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBackExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuBackExit.Name = "mnuBackExit";
            this.mnuBackExit.Size = new System.Drawing.Size(68, 20);
            this.mnuBackExit.Text = "Back/Exit";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(180, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmEnterResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.btnSubmitResult);
            this.Controls.Add(this.txtAwayGoals);
            this.Controls.Add(this.lblAwayGoals);
            this.Controls.Add(this.txtHomeGoals);
            this.Controls.Add(this.lblHomeGoals);
            this.Controls.Add(this.btnSelectFixture);
            this.Controls.Add(this.cboSelectFixture);
            this.Controls.Add(this.lblSelectFixture);
            this.Controls.Add(this.cboSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Name = "frmEnterResult";
            this.Text = "PremierLeagueSYS - Enter Result";
            this.Load += new System.EventHandler(this.frmEnterResult_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmitResult;
        private System.Windows.Forms.TextBox txtAwayGoals;
        private System.Windows.Forms.Label lblAwayGoals;
        private System.Windows.Forms.TextBox txtHomeGoals;
        private System.Windows.Forms.Label lblHomeGoals;
        private System.Windows.Forms.Button btnSelectFixture;
        private System.Windows.Forms.ComboBox cboSelectFixture;
        private System.Windows.Forms.Label lblSelectFixture;
        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuTeams;
        private System.Windows.Forms.ToolStripMenuItem mnuAddTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuEditTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuFixtures;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateFixtures;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleFixtures;
        private System.Windows.Forms.ToolStripMenuItem mnuReschedule;
        private System.Windows.Forms.ToolStripMenuItem mnuEnterResult;
        private System.Windows.Forms.ToolStripMenuItem viewResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateLeagueTable;
        private System.Windows.Forms.ToolStripMenuItem mnuSeasons;
        private System.Windows.Forms.ToolStripMenuItem mnuNewSeason;
        private System.Windows.Forms.ToolStripMenuItem mnuPastSeasons;
        private System.Windows.Forms.ToolStripMenuItem mnuBackExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}