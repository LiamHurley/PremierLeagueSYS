using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            if(Fixture.fixturesExist())
            {
                MessageBox.Show("You may not add a team after fixtures have been generated!\n\nReturning to main menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Visible = true;
                return;
            }
            
            if (Team.countTeams() == 6)
            {
                MessageBox.Show("You may not add a team when there are already 6 teams in the league!\n\nReturning to main menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Visible = true;
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            
            if (txtTeamName.Text.Contains("  "))
            {
                MessageBox.Show("Team Name invalid - contains consecutive spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeamName.Focus();
                return;
            }

            if (!Team.isValidTeamName(txtTeamName.Text.ToLower().Trim()))
            {
                MessageBox.Show("Team Name contains invalid characters!\n\nInput may only contain the following:" +
                    "\nUppercase letters\nLowercase letters\nNumbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeamName.Focus();
                return;
            }

            if (Team.teamExists(txtTeamName.Text.ToLower().Trim()))
            {
                MessageBox.Show("This team already exists in the Premier League!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeamName.Focus();
                return;
            }

            if (txtManager.Text.Contains("  "))
            {
                MessageBox.Show("Manager Name invalid - contains consecutive spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManager.Focus();
                return;
            }

            if (!Team.isValidManager(txtManager.Text.ToLower().Trim()))
            {
                MessageBox.Show("Manager Name contains invalid characters\n\nInput may only contain the following:" +
                   "\nUppercase letters\nLowercase letters\nApostrophes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManager.Focus();
                return;
            }

            if (Team.managerExists(txtManager.Text.ToLower().Trim()))
            {
                MessageBox.Show("This manager already exists in the Premier League!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManager.Focus();
                return;
            }

            if (!Team.isValidStadium(txtStadium.Text.ToLower().Trim()))
            {
                MessageBox.Show("Stadium contains invalid characters\n\nInput may only contain the following:" +
                    "\nUppercase letters\nLowercase letters\nNumbers\nApostrophes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStadium.Focus();
                return;
            }

            if (txtStadium.Text.Contains("  "))
            {
                MessageBox.Show("Stadium invalid - contains consecutive spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTeamName.Text) || string.IsNullOrEmpty(txtManager.Text) || string.IsNullOrEmpty(txtStadium.Text) || 
                string.IsNullOrEmpty(txtStadiumCapacity.Text) || string.IsNullOrEmpty(txtLocation.Text)){
                
                MessageBox.Show("Fields may not be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Team.isNumeric(txtStadiumCapacity.Text))
            {
                MessageBox.Show("Stadium capacity must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStadiumCapacity.Focus();
                return;
            }

            if (Int32.Parse(txtStadiumCapacity.Text) < 5000)
            {
                MessageBox.Show("Stadium capacity must be at least 5000 to meet Premier League regulations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStadiumCapacity.Focus();
                return;
            }

            if (!Team.isValidLocation(txtLocation.Text.ToLower().Trim()))
            {
                MessageBox.Show("Location contains invalid characters\n\nInput may only contain the following:" +
                    "\nUppercase letters\nLowercase letters\nNumbers\nCommas\nApostrophes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
                return;
            }

            if (txtLocation.Text.Contains("  "))
            {
                MessageBox.Show("Location invalid - contains consecutive spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
                return;
            }

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to add this team to the Premier League?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                Team t = new Team(txtTeamName.Text.Trim(), txtManager.Text.Trim(), txtStadium.Text.Trim(), Int32.Parse(txtStadiumCapacity.Text), txtLocation.Text.Trim());
                
                try
                {
                    t.addTeam();
                    
                    MessageBox.Show("You have successfully added " + txtTeamName.Text.Trim() + " to the Premier League!");
                    
                    txtTeamName.Clear();
                    txtManager.Clear();
                    txtStadium.Clear();
                    txtStadiumCapacity.Clear();
                    txtLocation.Clear();
                }
                catch
                {
                    MessageBox.Show("Error encountered\n\nReturning to main menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    parent.Visible = true;
                }
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
