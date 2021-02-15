namespace PremierLeagueSYS
{
    partial class frmScheduleFixture
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
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectFixture = new System.Windows.Forms.Label();
            this.cboSelectFixture = new System.Windows.Forms.ComboBox();
            this.btnSelectFixture = new System.Windows.Forms.Button();
            this.lblFixTime = new System.Windows.Forms.Label();
            this.lblFixDate = new System.Windows.Forms.Label();
            this.btnScheduleFixture = new System.Windows.Forms.Button();
            this.dtpFixDate = new System.Windows.Forms.DateTimePicker();
            this.cboTimes = new System.Windows.Forms.ComboBox();
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
            this.mnuMainStrip.TabIndex = 8;
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
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.Location = new System.Drawing.Point(78, 56);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(121, 24);
            this.lblSelectTeam.TabIndex = 9;
            this.lblSelectTeam.Text = "Select Team:";
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectTeam.DropDownWidth = 250;
            this.cboSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(251, 57);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(249, 26);
            this.cboSelectTeam.TabIndex = 10;
            this.cboSelectTeam.SelectedValueChanged += new System.EventHandler(this.cboSelectTeam_SelectedValueChanged);
            // 
            // lblSelectFixture
            // 
            this.lblSelectFixture.AutoSize = true;
            this.lblSelectFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFixture.Location = new System.Drawing.Point(78, 122);
            this.lblSelectFixture.Name = "lblSelectFixture";
            this.lblSelectFixture.Size = new System.Drawing.Size(130, 24);
            this.lblSelectFixture.TabIndex = 12;
            this.lblSelectFixture.Text = "Select Fixture:";
            // 
            // cboSelectFixture
            // 
            this.cboSelectFixture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectFixture.DropDownWidth = 350;
            this.cboSelectFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectFixture.FormattingEnabled = true;
            this.cboSelectFixture.Location = new System.Drawing.Point(251, 120);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(249, 26);
            this.cboSelectFixture.TabIndex = 13;
            // 
            // btnSelectFixture
            // 
            this.btnSelectFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFixture.ForeColor = System.Drawing.Color.Red;
            this.btnSelectFixture.Location = new System.Drawing.Point(543, 92);
            this.btnSelectFixture.Name = "btnSelectFixture";
            this.btnSelectFixture.Size = new System.Drawing.Size(143, 54);
            this.btnSelectFixture.TabIndex = 14;
            this.btnSelectFixture.Text = "Select Fixture";
            this.btnSelectFixture.UseVisualStyleBackColor = true;
            this.btnSelectFixture.Click += new System.EventHandler(this.btnSelectFixture_Click);
            // 
            // lblFixTime
            // 
            this.lblFixTime.AutoSize = true;
            this.lblFixTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixTime.Location = new System.Drawing.Point(81, 242);
            this.lblFixTime.Name = "lblFixTime";
            this.lblFixTime.Size = new System.Drawing.Size(121, 24);
            this.lblFixTime.TabIndex = 17;
            this.lblFixTime.Text = "Fixture Time:";
            this.lblFixTime.Visible = false;
            // 
            // lblFixDate
            // 
            this.lblFixDate.AutoSize = true;
            this.lblFixDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixDate.Location = new System.Drawing.Point(81, 181);
            this.lblFixDate.Name = "lblFixDate";
            this.lblFixDate.Size = new System.Drawing.Size(116, 24);
            this.lblFixDate.TabIndex = 15;
            this.lblFixDate.Text = "Fixture Date:";
            this.lblFixDate.Visible = false;
            // 
            // btnScheduleFixture
            // 
            this.btnScheduleFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleFixture.ForeColor = System.Drawing.Color.Red;
            this.btnScheduleFixture.Location = new System.Drawing.Point(543, 213);
            this.btnScheduleFixture.Name = "btnScheduleFixture";
            this.btnScheduleFixture.Size = new System.Drawing.Size(143, 54);
            this.btnScheduleFixture.TabIndex = 19;
            this.btnScheduleFixture.Text = "Schedule Fixture";
            this.btnScheduleFixture.UseVisualStyleBackColor = true;
            this.btnScheduleFixture.Visible = false;
            this.btnScheduleFixture.Click += new System.EventHandler(this.btnScheduleFixture_Click);
            // 
            // dtpFixDate
            // 
            this.dtpFixDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFixDate.Location = new System.Drawing.Point(251, 185);
            this.dtpFixDate.MaxDate = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.dtpFixDate.MinDate = new System.DateTime(2021, 8, 6, 0, 0, 0, 0);
            this.dtpFixDate.Name = "dtpFixDate";
            this.dtpFixDate.Size = new System.Drawing.Size(249, 20);
            this.dtpFixDate.TabIndex = 20;
            this.dtpFixDate.Value = new System.DateTime(2021, 8, 6, 0, 0, 0, 0);
            this.dtpFixDate.Visible = false;
            // 
            // cboTimes
            // 
            this.cboTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimes.DropDownWidth = 350;
            this.cboTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimes.FormattingEnabled = true;
            this.cboTimes.Items.AddRange(new object[] {
            "12:00",
            "12:30",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "19:30",
            "20:00"});
            this.cboTimes.Location = new System.Drawing.Point(251, 240);
            this.cboTimes.Name = "cboTimes";
            this.cboTimes.Size = new System.Drawing.Size(249, 26);
            this.cboTimes.TabIndex = 21;
            this.cboTimes.Visible = false;
            // 
            // frmScheduleFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboTimes);
            this.Controls.Add(this.dtpFixDate);
            this.Controls.Add(this.btnScheduleFixture);
            this.Controls.Add(this.lblFixTime);
            this.Controls.Add(this.lblFixDate);
            this.Controls.Add(this.btnSelectFixture);
            this.Controls.Add(this.cboSelectFixture);
            this.Controls.Add(this.lblSelectFixture);
            this.Controls.Add(this.cboSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.mnuMainStrip);
            this.Name = "frmScheduleFixture";
            this.Text = "Premier League SYS - Schedule Fixture";
            this.Load += new System.EventHandler(this.frmScheduleFixture_Load);
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
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectFixture;
        private System.Windows.Forms.ComboBox cboSelectFixture;
        private System.Windows.Forms.Button btnSelectFixture;
        private System.Windows.Forms.Label lblFixTime;
        private System.Windows.Forms.Label lblFixDate;
        private System.Windows.Forms.Button btnScheduleFixture;
        private System.Windows.Forms.DateTimePicker dtpFixDate;
        private System.Windows.Forms.ComboBox cboTimes;
    }
}