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
            this.mnuMainStrip = new System.Windows.Forms.MenuStrip();
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
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuMainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainStrip
            // 
            this.mnuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTeams,
            this.mnuFixturesResults,
            this.mnuBackExit});
            this.mnuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainStrip.Name = "mnuMainStrip";
            this.mnuMainStrip.Size = new System.Drawing.Size(800, 24);
            this.mnuMainStrip.TabIndex = 9;
            this.mnuMainStrip.Text = "menuStrip1";
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
            this.mnuBack,
            this.mnuExit});
            this.mnuBackExit.Name = "mnuBackExit";
            this.mnuBackExit.Size = new System.Drawing.Size(68, 20);
            this.mnuBackExit.Text = "Back/Exit";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(99, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(99, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnSubmitResult
            // 
            this.btnSubmitResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitResult.ForeColor = System.Drawing.Color.Red;
            this.btnSubmitResult.Location = new System.Drawing.Point(536, 224);
            this.btnSubmitResult.Name = "btnSubmitResult";
            this.btnSubmitResult.Size = new System.Drawing.Size(143, 54);
            this.btnSubmitResult.TabIndex = 29;
            this.btnSubmitResult.Text = "Submit Result";
            this.btnSubmitResult.UseVisualStyleBackColor = true;
            this.btnSubmitResult.Visible = false;
            this.btnSubmitResult.Click += new System.EventHandler(this.btnSubmitResult_Click);
            // 
            // txtAwayGoals
            // 
            this.txtAwayGoals.Location = new System.Drawing.Point(244, 259);
            this.txtAwayGoals.Name = "txtAwayGoals";
            this.txtAwayGoals.Size = new System.Drawing.Size(249, 20);
            this.txtAwayGoals.TabIndex = 28;
            this.txtAwayGoals.Visible = false;
            // 
            // lblAwayGoals
            // 
            this.lblAwayGoals.AutoSize = true;
            this.lblAwayGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwayGoals.Location = new System.Drawing.Point(74, 254);
            this.lblAwayGoals.Name = "lblAwayGoals";
            this.lblAwayGoals.Size = new System.Drawing.Size(114, 24);
            this.lblAwayGoals.TabIndex = 27;
            this.lblAwayGoals.Text = "Away Goals:";
            this.lblAwayGoals.Visible = false;
            // 
            // txtHomeGoals
            // 
            this.txtHomeGoals.Location = new System.Drawing.Point(244, 198);
            this.txtHomeGoals.Name = "txtHomeGoals";
            this.txtHomeGoals.Size = new System.Drawing.Size(249, 20);
            this.txtHomeGoals.TabIndex = 26;
            this.txtHomeGoals.Visible = false;
            // 
            // lblHomeGoals
            // 
            this.lblHomeGoals.AutoSize = true;
            this.lblHomeGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGoals.Location = new System.Drawing.Point(74, 193);
            this.lblHomeGoals.Name = "lblHomeGoals";
            this.lblHomeGoals.Size = new System.Drawing.Size(120, 24);
            this.lblHomeGoals.TabIndex = 25;
            this.lblHomeGoals.Text = "Home Goals:";
            this.lblHomeGoals.Visible = false;
            // 
            // btnSelectFixture
            // 
            this.btnSelectFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFixture.ForeColor = System.Drawing.Color.Red;
            this.btnSelectFixture.Location = new System.Drawing.Point(536, 104);
            this.btnSelectFixture.Name = "btnSelectFixture";
            this.btnSelectFixture.Size = new System.Drawing.Size(143, 54);
            this.btnSelectFixture.TabIndex = 24;
            this.btnSelectFixture.Text = "Select Fixture";
            this.btnSelectFixture.UseVisualStyleBackColor = true;
            this.btnSelectFixture.Click += new System.EventHandler(this.btnSelectFixture_Click);
            // 
            // cboSelectFixture
            // 
            this.cboSelectFixture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectFixture.DropDownWidth = 350;
            this.cboSelectFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectFixture.FormattingEnabled = true;
            this.cboSelectFixture.Location = new System.Drawing.Point(244, 132);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(249, 26);
            this.cboSelectFixture.TabIndex = 23;
            // 
            // lblSelectFixture
            // 
            this.lblSelectFixture.AutoSize = true;
            this.lblSelectFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFixture.Location = new System.Drawing.Point(71, 134);
            this.lblSelectFixture.Name = "lblSelectFixture";
            this.lblSelectFixture.Size = new System.Drawing.Size(130, 24);
            this.lblSelectFixture.TabIndex = 22;
            this.lblSelectFixture.Text = "Select Fixture:";
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectTeam.DropDownWidth = 250;
            this.cboSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(244, 69);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(249, 26);
            this.cboSelectTeam.TabIndex = 21;
            this.cboSelectTeam.SelectedValueChanged += new System.EventHandler(this.cboSelectTeam_SelectedValueChanged);
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.Location = new System.Drawing.Point(71, 68);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(121, 24);
            this.lblSelectTeam.TabIndex = 20;
            this.lblSelectTeam.Text = "Select Team:";
            // 
            // frmEnterResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.mnuMainStrip);
            this.Name = "frmEnterResult";
            this.Text = "PremierLeagueSYS - Enter Result";
            this.Load += new System.EventHandler(this.frmEnterResult_Load);
            this.mnuMainStrip.ResumeLayout(false);
            this.mnuMainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainStrip;
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
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
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
    }
}