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
            DataTable teamsList = Team.getTeams();

            for (int i = 0; i < teamsList.Rows.Count; i++)
            {
                cboSelectTeam.Items.Add(Convert.ToInt32(teamsList.Rows[i]["TEAM_ID"]).ToString("000")+" - "+teamsList.Rows[i]["NAME"].ToString());
            }
        }
        
        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
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

        private void cboSelectTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            String idStr = cboSelectTeam.Text.Substring(0, 3);

            if (idStr.Substring(0, 2).Equals("00"))
            {
                idStr = idStr.Remove(0, 2);
            }
            else if (idStr[0] == '0' && idStr[1] != '0')
            {
                idStr = idStr.Remove(0, 1);
            }
            
            t.getTeam(Convert.ToInt32(idStr));
            
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
                MessageBox.Show("Please select a team.");
                return;
            }

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to update " + cboSelectTeam.Text.Substring(6) + "'s details?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;

            if (txtManager.Text != originalManager)
            {
                if (Team.managerExists(txtManager.Text))
                {
                    MessageBox.Show("This manager already exists in the Premier League!");
                    txtManager.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtTeamName.Text) || string.IsNullOrEmpty(txtManager.Text) || string.IsNullOrEmpty(txtStadium.Text) || string.IsNullOrEmpty(txtStadiumCapacity.Text) || string.IsNullOrEmpty(txtLocation.Text))
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

            if (dialog1 == DialogResult.Yes)
            {
                try
                {
                    t.manager = txtManager.Text;
                    t.stadium = txtStadium.Text;
                    t.capacity = Convert.ToInt32(txtStadiumCapacity.Text);
                    t.location = txtLocation.Text;
                    t.updateTeam();

                    TextBox[] boxes = { txtTeamName, txtManager, txtStadium, txtStadiumCapacity, txtLocation };
                    Label[] labels = { lblTeamName, lblManager, lblStadium, lblStadiumCapacity, lblLocation };

                    for (int i = 0; i < labels.Length; i++)
                    {
                        labels[i].Hide();
                        boxes[i].Hide();
                        boxes[i].Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Error encountered.");
                }
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
    }
}
