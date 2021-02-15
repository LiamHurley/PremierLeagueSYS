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
    public partial class frmEditTeamDetails : Form
    {
        public frmEditTeamDetails()
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

        private void mnuBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to return to the main menu?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void frmEditTeamDetails_Load(object sender, EventArgs e)
        {
            txtTeamName.Text = "Arsenal";
            txtManager.Text = "Mikel Arteta";
            txtStadium.Text = "Emirates Stadium";
            txtStadiumCapacity.Text = "64000";
            txtLocation.Text = "London";
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            String teamName = txtTeamName.Text;
            String manager = txtManager.Text;
            String stadium = txtStadium.Text;
            String stadiumCapacity = txtStadiumCapacity.Text;
            String location = txtLocation.Text;
            int capacity = Int32.Parse(txtStadiumCapacity.Text);

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to update these details?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(teamName) && !string.IsNullOrEmpty(manager) && !string.IsNullOrEmpty(stadium) && !string.IsNullOrEmpty(stadiumCapacity) && !string.IsNullOrEmpty(location))
                {
                    if (txtTeamName.Text != "Manchester United")
                    {
                        if (txtManager.Text != "Pep Guardiola")
                        {
                            if (capacity > 5000)
                            {
                                MessageBox.Show(teamName + " details successfully edited! Returning to team selection screen!");
                                frmEditTeam form2 = new frmEditTeam();
                                this.Hide();
                                form2.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Stadium capacity must be larger than 5000 due to Premier League restrictions!");
                                txtStadiumCapacity.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This manager already exists in the Premier League!");
                            txtManager.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This team already exists in the Premier League!");
                        txtTeamName.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled!");
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
