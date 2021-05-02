using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PremierLeagueSYS
{
    public partial class frmEditTeam : Form
    {
        private frmMainMenu parent;
        private String originalManager;
        Team t = new Team();
        
        public frmEditTeam()
        {
            InitializeComponent();
        }

        public frmEditTeam(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmEditTeam_Load(object sender, EventArgs e)
        {
            Team.loadTeams(cboSelectTeam);
        }
        
        private void cboSelectTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSelectTeam.SelectedIndex == -1)
                return;
            
            t.getTeamInfo(Convert.ToInt32(Utility.deformatId(cboSelectTeam.Text.Substring(0, 3))));
            
            TextBox[] boxes = { txtTeamName, txtManager, txtStadium, txtStadiumCapacity, txtLocation };
            Label[] labels = { lblTeamName, lblManager, lblStadium, lblStadiumCapacity, lblLocation };
            
            txtTeamName.Text = t.name;
            txtManager.Text = t.manager;
            txtStadium.Text = t.stadium;
            txtStadiumCapacity.Text = t.capacity.ToString();
            txtLocation.Text = t.location;
            
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Show();
                boxes[i].Show();
            }
            
            originalManager = txtManager.Text;
            txtTeamName.Enabled = false;
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSelectTeam.Text))
            {
                MessageBox.Show("Please select a team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Team.isValidManager(txtManager.Text.ToLower().Trim()))
            {
                MessageBox.Show("Manager Name contains invalid characters\n\nInput may only contain the following:" +
                   "\nUppercase letters\nLowercase letters\nApostrophes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManager.Focus();
                return;
            }

            if (txtManager.Text.Contains("  "))
            {
                MessageBox.Show("Manager Name invalid - contains consecutive spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManager.Focus();
                return;
            }

            if (txtManager.Text.ToLower().Trim() != originalManager.ToLower())
            {
                if (Team.managerExists(txtManager.Text.ToLower().Trim()))
                {
                    MessageBox.Show("This manager already exists in the Premier League!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtManager.Focus();
                    return;
                }
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

            if (string.IsNullOrEmpty(txtTeamName.Text) || string.IsNullOrEmpty(txtManager.Text) || string.IsNullOrEmpty(txtStadium.Text) || string.IsNullOrEmpty(txtStadiumCapacity.Text) || string.IsNullOrEmpty(txtLocation.Text))
            {
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

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to update " + cboSelectTeam.Text.Substring(6) + "'s details?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;

            if (dialog1 == DialogResult.Yes)
            {
                t.manager = txtManager.Text.Trim();
                t.stadium = txtStadium.Text.Trim();
                t.capacity = Convert.ToInt32(txtStadiumCapacity.Text);
                t.location = txtLocation.Text.Trim();

                try
                {
                    t.updateTeam();
                }
                catch
                {
                    MessageBox.Show("Error encountered\n\nReturning to main menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    parent.Visible = true;
                }

                TextBox[] boxes = { txtTeamName, txtManager, txtStadium, txtStadiumCapacity, txtLocation };
                Label[] labels = { lblTeamName, lblManager, lblStadium, lblStadiumCapacity, lblLocation };

                for (int i = 0; i < labels.Length; i++)
                {
                    labels[i].Hide();
                    boxes[i].Hide();
                    boxes[i].Clear();
                }

                cboSelectTeam.SelectedIndex = -1;
            }
        }

        private void txtStadiumCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // following code sourced from https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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
