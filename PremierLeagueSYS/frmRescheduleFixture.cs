using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierLeagueSYS
{
    public partial class frmRescheduleFixture : Form
    {
        private frmMainMenu parent;
        private Fixture f = new Fixture();
        private int startYear;
        private List<DateTime> dates = new List<DateTime>();

        public frmRescheduleFixture()
        {
            InitializeComponent();
        }

        public frmRescheduleFixture(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmRescheduleFixture_Load(object sender, EventArgs e)
        {
            if (!Fixture.fixturesExist())
            {
                MessageBox.Show("Fixtures for the new season have not yet been generated!\n\nReturning to main menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Visible = true;
                return;
            }

            startYear = Team.getLastYear();

            dates = Fixture.setDateLimits(startYear);

            dtpFixDate.MaxDate = dates[0];
            dtpFixDate.MinDate = dates[1];
            if (DateTime.Today > dates[1])
                dtpFixDate.Value = DateTime.Today;
            else
                dtpFixDate.Value = dates[1];

            Team.loadTeams(cboSelectTeam);
        }

        private void cboSelectTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSelectTeam.SelectedIndex == -1)
                return;

            cboSelectFixture.Items.Clear();

            DataTable dt = Fixture.getUnplayedFixtures(Convert.ToInt32(Utility.deformatId(cboSelectTeam.Text.Substring(0, 3))));

            Fixture.loadFixtures(dt, cboSelectFixture);
        }

        private void btnSelectFixture_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSelectTeam.Text) || string.IsNullOrEmpty(cboSelectFixture.Text))
            {
                MessageBox.Show("You must select a team and a fixture to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to reschedule " + cboSelectFixture.Text.Substring(6) + "?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                f.id = Convert.ToInt32(Utility.deformatId(cboSelectFixture.Text.Substring(0, 3)));
                f.date = Fixture.getFixDate(Convert.ToInt32(Utility.deformatId(cboSelectFixture.Text.Substring(0, 3))));
                f.time = Fixture.getFixTime(Convert.ToInt32(Utility.deformatId(cboSelectFixture.Text.Substring(0, 3))));

                btnSelectFixture.Hide();
                lblFixDate.Show();
                lblFixTime.Show();
                
                dtpFixDate.Value = Convert.ToDateTime(f.date);
                dtpFixDate.Show();
                
                cboTimes.Text = f.time;
                cboTimes.Show();
                
                btnScheduleFixture.Show();
                cboSelectTeam.Enabled = false;
                cboSelectFixture.Enabled = false;
            }
        }

        private void btnScheduleFixture_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Utility.deformatId(cboSelectFixture.Text.Substring(0, 3)));

            if (string.IsNullOrEmpty(cboTimes.Text) || string.IsNullOrEmpty(dtpFixDate.Text))
            {
                MessageBox.Show("You must select a time and date to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to reschedule " + cboSelectFixture.Text + " with the following date and time?\n\nDate: " + dtpFixDate.Text + "\nTime: "
                                                + cboTimes.Text, "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 != DialogResult.Yes)
                return;

            if (!Fixture.isValidDate(id, dtpFixDate.Text))
            {
                MessageBox.Show("One of the teams in this fixture already has a game scheduled for " + dtpFixDate.Text + ".\n\nPlease select a different date."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixDate.Focus();
                return;
            }

            if (Fixture.isCongestion(id, Convert.ToDateTime(dtpFixDate.Text)))
            {
                MessageBox.Show("One of the teams in this fixture already has a game scheduled within 3 days of " + dtpFixDate.Text + ".\n\nPlease select a" +
                    " different date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixDate.Focus();
                return;
            }

            f.date = dtpFixDate.Text;
            f.time = cboTimes.Text;

            f.schedule();

            MessageBox.Show("You have successfully rescheduled Match No #" + cboSelectFixture.Text.Substring(0, 3) + 
                " to be played on:\n\nDate: " + dtpFixDate.Text + "\nTime: " + cboTimes.Text);

            lblFixDate.Hide();
            lblFixTime.Hide();
            dtpFixDate.Hide();
            
            if (DateTime.Today > dates[1])
                dtpFixDate.Value = DateTime.Today;
            else
                dtpFixDate.Value = dates[1];
            
            cboTimes.Hide();
            cboTimes.SelectedIndex = -1;
            
            btnSelectFixture.Show();
            btnScheduleFixture.Hide();
            
            cboSelectTeam.SelectedIndex = -1;
            cboSelectFixture.SelectedIndex = -1;
            cboSelectTeam.Enabled = true;
            cboSelectFixture.Enabled = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to return to the main menu?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                this.Close();
                parent.Visible = true;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }
    
}
}
