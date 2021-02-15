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
    public partial class frmGenerateTeamProfile : Form
    {
        public frmGenerateTeamProfile()
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

            if(dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            String selectedTeam = cboSelectTeam.SelectedItem.ToString();

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish generate " + selectedTeam + "'s Team Profile?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                MessageBox.Show(selectedTeam + " Team Profile is as follows:");
            }
        }
    }
}
