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
    public partial class frmRemoveTeam : Form
    {

        private frmMainMenu parent;
        public frmRemoveTeam()
        {
            InitializeComponent();

        }

        public frmRemoveTeam(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmRemoveTeam_Load(object sender, EventArgs e)
        {
            DataTable teamsList = Team.getTeams();

            for (int i = 0; i < teamsList.Rows.Count; i++)
            {
                this.cboTeams.Items.Add(teamsList.Rows[i]["NAME"].ToString());
            }
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            if (Fixture.fixturesExist())
            {
                MessageBox.Show("You may not remove a team after fixtures have been generated for the season. Application will now exit.");
                Application.Exit();
            }

            if (!string.IsNullOrEmpty(cboTeams.Text))
            {
                Team.removeTeam(cboTeams.SelectedItem.ToString());
                cboTeams.Items.Remove(cboTeams.SelectedItem.ToString());
            }

            else
            {
                MessageBox.Show("Please select a team.");
                return;
            }
        }

        private void mnuRemoveTeamExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void mnuRemoveTeamBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to return to the main menu?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                this.Close();
                parent.Visible = true;
            }
        }
    }
}
