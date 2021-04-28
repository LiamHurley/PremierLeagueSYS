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
        Team t = new Team();
        
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
            Team.loadTeams(cboTeams); 
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            if (Fixture.fixturesExist())
            {
                MessageBox.Show("You may not remove a team after fixtures have been generated for the season.\n\nReturning to the main menu."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Visible = true;
            }

            if (string.IsNullOrEmpty(cboTeams.Text))
            {
                MessageBox.Show("Please select a team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog1 = MessageBox.Show("Are you sure you want to remove "+cboTeams.Text.Substring(6)+" from the Premier League?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

            if(dialog1==DialogResult.Yes)
            {
                t.getTeamInfo(Convert.ToInt32(Utility.deformatId(cboTeams.Text.Substring(0, 3))));

                try
                {
                    t.removeTeam();
                }
                catch
                {
                    MessageBox.Show("Error encountered\n\nReturning to main menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    parent.Visible = true;
                }
                
                cboTeams.Items.Remove(cboTeams.SelectedItem);
                cboTeams.SelectedIndex = -1;
            }
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
