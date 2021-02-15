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
    public partial class frmScheduleFixture : Form
    {
        private frmMainMenu parent;
        private Fixture f = new Fixture();
        private int startYear;
        private List<DateTime> dates= new List<DateTime>();

        public frmScheduleFixture()
        {
            InitializeComponent();
        }

        public frmScheduleFixture(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmScheduleFixture_Load(object sender, EventArgs e)
        {
            if (!Fixture.fixturesExist())
            {
                MessageBox.Show("Fixtures for the new season have not yet been generated!\n\nReturning to main menu.");
                this.Close();
                parent.Visible = true;
            }

            startYear = Team.getLastYear();
            dates = Fixture.setDateLimits(startYear);
            
            dtpFixDate.MaxDate = dates[0];
            dtpFixDate.MinDate = dates[1];
            if (DateTime.Today > dates[1])
                dtpFixDate.Value = DateTime.Today;
            else
                dtpFixDate.Value = dates[1];

            DataTable teamsList = Team.getTeams();

            for (int i = 0; i < teamsList.Rows.Count; i++)
            {
                cboSelectTeam.Items.Add(teamsList.Rows[i]["NAME"].ToString());
            }
        }

        private void cboSelectTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            cboSelectFixture.Items.Clear();
            String selectedTeam = cboSelectTeam.SelectedItem.ToString();
            
            int id = Team.getTeamId(selectedTeam);
            
            DataTable dt = Fixture.getUnplayedFixtures(id);

            foreach (DataRow dr in dt.Rows)
                cboSelectFixture.Items.Add(Convert.ToInt32(dr["FIX_ID"]).ToString("000") + " - " + dr["HomeTeam"].ToString() + " vs " + dr["AwayTeam"].ToString());
        }
        
        private void btnSelectFixture_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cboSelectTeam.Text) || string.IsNullOrEmpty(cboSelectFixture.Text))
            {
                MessageBox.Show("You must select a team and a fixture to proceed.");
                return;
            }

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to schedule " + cboSelectFixture.Text.Substring(6) + "?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog1 == DialogResult.Yes)
            {
                String idStr = cboSelectFixture.Text.Substring(0, 3);

                if (idStr.Substring(0, 2).Equals("00"))
                {
                    idStr = idStr.Remove(0, 2);
                }
                else if (idStr[0] == '0' && idStr[1] != '0')
                {
                    idStr = idStr.Remove(0, 1);
                }

                f.id = Convert.ToInt32(idStr);

                btnSelectFixture.Hide();
                lblFixDate.Show();
                lblFixTime.Show();
                dtpFixDate.Show();
                cboTimes.Show();
                btnScheduleFixture.Show();
                cboSelectTeam.Enabled = false;
                cboSelectFixture.Enabled = false;
            }
        }

        private void btnScheduleFixture_Click(object sender, EventArgs e)
        {
            String idStr = cboSelectFixture.Text.Substring(0, 3);

            if (idStr.Substring(0, 2).Equals("00"))
            {
                idStr = idStr.Remove(0, 2);
            }
            else if (idStr[0] == '0' && idStr[1] != '0')
            {
                idStr = idStr.Remove(0, 1);
            }
            
            int id = Convert.ToInt32(idStr); 
            
            if (string.IsNullOrEmpty(cboTimes.Text) || string.IsNullOrEmpty(dtpFixDate.Text))
            {
                MessageBox.Show("You must select a time and date to proceed.");
                return;
            }

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to schedule " + cboSelectFixture.Text + " with the following date and time?\n\nDate: " + dtpFixDate.Text + "\nTime: " 
                                                + cboTimes.Text, "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog1 != DialogResult.Yes)
                return;

            if (!Fixture.isValidDate(id,dtpFixDate.Text))
            {
                MessageBox.Show("One of the teams in this fixture already has a game scheduled for "+dtpFixDate.Text+".\n\nPlease select a different date.");
                dtpFixDate.Focus();
                return;
            }

            if(Fixture.isCongestion(id,Convert.ToDateTime(dtpFixDate.Text)))
            {
                MessageBox.Show("One of the teams in this fixture already has a game scheduled within 3 days of " + dtpFixDate.Text + ".\n\nPlease select a" +
                    " different date.");
                dtpFixDate.Focus();
                return;
            }

            f.date = dtpFixDate.Text;
            f.time = cboTimes.Text;
            
            f.schedule();
            
            MessageBox.Show("You have successfully scheduled Match No #" + id + " to be played on:\n\nDate: " + dtpFixDate.Text + "\nTime: " + cboTimes.Text);

            lblFixDate.Hide();
            lblFixTime.Hide();
            dtpFixDate.Hide();
            if (DateTime.Today > dates[1])
                dtpFixDate.Value = DateTime.Today;
            else
                dtpFixDate.Value = dates[1];
            cboTimes.Hide();
            cboTimes.ResetText();
            btnSelectFixture.Show();
            btnScheduleFixture.Hide();
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
