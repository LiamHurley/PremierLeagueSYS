using System;
using System.Windows.Forms;

namespace PremierLeagueSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void mnuAddTeam_Click(object sender, EventArgs e)
        {
            frmAddTeam nextForm = new frmAddTeam(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRemoveTeam_Click(object sender, EventArgs e)
        {
            frmRemoveTeam nextForm = new frmRemoveTeam(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuEditTeam_Click(object sender, EventArgs e)
        {
            frmEditTeam nextForm = new frmEditTeam(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuGenerateProfile_Click(object sender, EventArgs e)
        {
            frmGenerateTeamProfile nextForm = new frmGenerateTeamProfile(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuGenerateFixtures_Click(object sender, EventArgs e)
        {
            frmGenerateFixtures nextForm = new frmGenerateFixtures(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuScheduleFixtures_Click(object sender, EventArgs e)
        {
            frmScheduleFixture nextForm = new frmScheduleFixture(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuEnterResult_Click(object sender, EventArgs e)
        {
            frmEnterResult nextForm = new frmEnterResult(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuGenerateLeagueTable_Click(object sender, EventArgs e)
        {
            frmGenerateLeagueTable nextForm = new frmGenerateLeagueTable(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuNewSeason_Click(object sender, EventArgs e)
        {
            frmNewSeason nextForm = new frmNewSeason(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuPastSeasons_Click(object sender, EventArgs e)
        {
            frmPastSeasons nextForm = new frmPastSeasons(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuReschedule_Click(object sender, EventArgs e)
        {
            frmRescheduleFixture nextForm = new frmRescheduleFixture(this);
            this.Hide();
            nextForm.Show();
        }

        private void viewResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewResults nextForm = new frmViewResults(this);
            this.Hide();
            nextForm.Show();
        }
    }
}
