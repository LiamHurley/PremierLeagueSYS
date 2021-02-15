using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PremierLeagueSYS
{
     public partial class frmAddTeam : Form
    {
        private frmMainMenu parent;
        
        public frmAddTeam()
        {
            InitializeComponent();
        }

        public frmAddTeam(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddTeam_Load(object sender, EventArgs e)
        {
            int teamsInLeague = Team.countTeams();

            if (teamsInLeague == 20)
            {
                MessageBox.Show("You may not add a team when there are already 20 teams in the league!!");
                Application.Exit();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void mnuAddTeamBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to return to the main menu?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                this.Close();
                parent.Visible = true;
            }
               
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to add this team to the Premier League?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Team.teamExists(txtTeamName.Text))
            {
                MessageBox.Show("This team already exists in the Premier League!");
                txtTeamName.Focus();
                return;
            }

            if (Team.managerExists(txtManager.Text))
            {
                MessageBox.Show("This manager already exists in the Premier League!");
                txtManager.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTeamName.Text) || string.IsNullOrEmpty(txtManager.Text) || string.IsNullOrEmpty(txtStadium.Text) || 
                string.IsNullOrEmpty(txtStadiumCapacity.Text) || string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Fields may not be left blank!");
                return;
            }

            if (!Team.isNumeric(txtStadiumCapacity.Text))
            {
                MessageBox.Show("Stadium capacity must be numeric.");
                txtStadiumCapacity.Focus();
                return;
            }

            if (Int32.Parse(txtStadiumCapacity.Text) < 5000)
            {
                MessageBox.Show("Stadium capacity must be at least 5000 to meet Premier League regulations.");
                txtStadiumCapacity.Focus();
                return;
            }


            if(dialog1 == DialogResult.Yes)
            {
                Team t = new Team(txtTeamName.Text, txtManager.Text, txtStadium.Text, Int32.Parse(txtStadiumCapacity.Text), txtLocation.Text);
                
                try
                {
                    t.addTeam();
                    
                    MessageBox.Show("You have successfully added " + txtTeamName.Text + " to the Premier League!");
                    
                    txtTeamName.Clear();
                    txtManager.Clear();
                    txtStadium.Clear();
                    txtStadiumCapacity.Clear();
                    txtLocation.Clear();
                }
                catch
                {
                    MessageBox.Show("Error encountered.");
                }
            }
        }
    }
}
