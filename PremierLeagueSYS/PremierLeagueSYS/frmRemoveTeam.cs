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
        public frmRemoveTeam()
        {
            InitializeComponent();
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            String selectedTeam = cboTeams.SelectedItem.ToString();
                
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to remove " + selectedTeam + " from the Premier League?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog1==DialogResult.Yes)
            {
                cboTeams.Items.Remove(cboTeams.SelectedItem);
                MessageBox.Show(selectedTeam + " removed from the Premier League successfully!!");
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
                Application.Exit();
        }

        private void frmRemoveTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
