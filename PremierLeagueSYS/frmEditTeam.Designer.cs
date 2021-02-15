namespace PremierLeagueSYS
{
    partial class frmEditTeam
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
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblStadiumCapacity = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtStadiumCapacity = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtStadium = new System.Windows.Forms.TextBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
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
            this.mnuMainStrip.TabIndex = 7;
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
            // btnEditTeam
            // 
            this.btnEditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeam.ForeColor = System.Drawing.Color.Red;
            this.btnEditTeam.Location = new System.Drawing.Point(479, 266);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(168, 85);
            this.btnEditTeam.TabIndex = 22;
            this.btnEditTeam.Text = "Edit Team";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(145, 212);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(52, 13);
            this.lblManager.TabIndex = 21;
            this.lblManager.Text = "Manager:";
            this.lblManager.Visible = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(145, 334);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 20;
            this.lblLocation.Text = "Location:";
            this.lblLocation.Visible = false;
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(145, 252);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(48, 13);
            this.lblStadium.TabIndex = 19;
            this.lblStadium.Text = "Stadium:";
            this.lblStadium.Visible = false;
            // 
            // lblStadiumCapacity
            // 
            this.lblStadiumCapacity.AutoSize = true;
            this.lblStadiumCapacity.Location = new System.Drawing.Point(145, 295);
            this.lblStadiumCapacity.Name = "lblStadiumCapacity";
            this.lblStadiumCapacity.Size = new System.Drawing.Size(92, 13);
            this.lblStadiumCapacity.TabIndex = 18;
            this.lblStadiumCapacity.Text = "Stadium Capacity:";
            this.lblStadiumCapacity.Visible = false;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(145, 171);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(68, 13);
            this.lblTeamName.TabIndex = 17;
            this.lblTeamName.Text = "Team Name:";
            this.lblTeamName.Visible = false;
            // 
            // txtStadiumCapacity
            // 
            this.txtStadiumCapacity.Location = new System.Drawing.Point(256, 292);
            this.txtStadiumCapacity.MaxLength = 5;
            this.txtStadiumCapacity.Name = "txtStadiumCapacity";
            this.txtStadiumCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtStadiumCapacity.TabIndex = 16;
            this.txtStadiumCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStadiumCapacity.Visible = false;
            this.txtStadiumCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStadiumCapacity_KeyPress);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(256, 331);
            this.txtLocation.MaxLength = 50;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 15;
            this.txtLocation.Visible = false;
            // 
            // txtStadium
            // 
            this.txtStadium.Location = new System.Drawing.Point(256, 249);
            this.txtStadium.MaxLength = 50;
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.Size = new System.Drawing.Size(100, 20);
            this.txtStadium.TabIndex = 14;
            this.txtStadium.Visible = false;
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(256, 209);
            this.txtManager.MaxLength = 50;
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(100, 20);
            this.txtManager.TabIndex = 13;
            this.txtManager.Visible = false;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(256, 168);
            this.txtTeamName.MaxLength = 50;
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 20);
            this.txtTeamName.TabIndex = 12;
            this.txtTeamName.Visible = false;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.Location = new System.Drawing.Point(116, 91);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(121, 24);
            this.lblSelectTeam.TabIndex = 23;
            this.lblSelectTeam.Text = "Select Team:";
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(256, 89);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(153, 26);
            this.cboSelectTeam.TabIndex = 24;
            this.cboSelectTeam.SelectedValueChanged += new System.EventHandler(this.cboSelectTeam_SelectedValueChanged);
            // 
            // frmEditTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblStadiumCapacity);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.txtStadiumCapacity);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtStadium);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.mnuMainStrip);
            this.Name = "frmEditTeam";
            this.Text = "PremierLeagueSYS - Edit Details";
            this.Load += new System.EventHandler(this.frmEditTeam_Load);
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
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblStadiumCapacity;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtStadiumCapacity;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtStadium;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.ComboBox cboSelectTeam;
    }
}