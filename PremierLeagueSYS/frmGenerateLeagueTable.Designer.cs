namespace PremierLeagueSYS
{
    partial class frmGenerateLeagueTable
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
            this.btnShowTable = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.mnuMainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
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
            this.mnuMainStrip.TabIndex = 10;
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
            // btnShowTable
            // 
            this.btnShowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.ForeColor = System.Drawing.Color.Red;
            this.btnShowTable.Location = new System.Drawing.Point(254, 124);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(294, 184);
            this.btnShowTable.TabIndex = 11;
            this.btnShowTable.Text = "Show League Table";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(58, 46);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(673, 372);
            this.dgvTable.TabIndex = 12;
            this.dgvTable.Visible = false;
            // 
            // frmGenerateLeagueTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnShowTable);
            this.Controls.Add(this.mnuMainStrip);
            this.Name = "frmGenerateLeagueTable";
            this.Text = "PremierLeagueSYS - League Table";
            this.mnuMainStrip.ResumeLayout(false);
            this.mnuMainStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
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
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.DataGridView dgvTable;
    }
}