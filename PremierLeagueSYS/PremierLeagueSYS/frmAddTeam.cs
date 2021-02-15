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
    public partial class frmAddTeam : Form
    {
        public frmAddTeam()
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

        private void mnuAddTeamBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to return to the main menu?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            String teamName = txtTeamName.Text;
            String manager = txtManager.Text;
            String stadium = txtStadium.Text;
            String stadiumCapacity = txtStadiumCapacity.Text;
            String location = txtLocation.Text;
            int stadiumCapacityAsInt = Int32.Parse(stadiumCapacity);
            int teamsInLeague = 20;

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to add this team to the Premier League?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (teamsInLeague < 20)
            {
                if (teamName != "Manchester United" && teamName != "Arsenal" && teamName != "Manchester City")
                {
                    if (manager != "Ole Gunnar Solsjkaer" && manager != "Mikel Arteta" && manager != "Pep Guardiola")
                    {
                        if (stadiumCapacityAsInt > 5000)
                        {
                            if (!string.IsNullOrEmpty(teamName) && !string.IsNullOrEmpty(manager) && !string.IsNullOrEmpty(stadium) && !string.IsNullOrEmpty(stadiumCapacity) && !string.IsNullOrEmpty(location))
                            {
                                if (dialog1 == DialogResult.Yes)
                                {
                                    MessageBox.Show(teamName + " have been added to the Premier League");
                                    txtTeamName.Clear();
                                    txtManager.Clear();
                                    txtStadium.Clear();
                                    txtStadiumCapacity.Clear();
                                    txtLocation.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Returning to data entry");
                                }
                            }
                            else
                                MessageBox.Show("All fields must be filled!!");
                        }
                        else
                        {
                            MessageBox.Show("Stadium capacity must be larger than 5000 to match Premier League regulations.");
                            txtStadiumCapacity.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show(manager + " is already the manager of a Premier League team!!");
                        txtManager.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("This team is already in the Premier League!");
                    txtTeamName.Clear();
                }
            }
            else
            {
                MessageBox.Show("There cannot be more than 20 teams in the Premier League!");
                Application.Exit();
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
