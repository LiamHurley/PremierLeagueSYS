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
        public frmEditTeam()
        {
            InitializeComponent();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to return to the main menu?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            String selectedTeam = cboSelectTeam.SelectedItem.ToString(); 
            
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to edit " + selectedTeam + "'s details?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog1==DialogResult.Yes)
            {
                frmEditTeamDetails form2 = new frmEditTeamDetails();
                this.Hide();
                form2.ShowDialog();
            }
        }
    }
}
