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
        private frmMainMenu parent;
        
        public frmGenerateTeamProfile()
        {
            InitializeComponent();
        }

        public frmGenerateTeamProfile(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent; 
        }

        private void frmGenerateTeamProfile_Load(object sender, EventArgs e)
        {
            Team.loadTeams(cboSelectTeam);
        }

        private void cboSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Team.getProfileStats(Convert.ToInt32(Utility.deformatId(cboSelectTeam.Text.Substring(0, 3))));

            DataTable profile = new DataTable();

            DataColumn c1 = new DataColumn();
            DataColumn c2 = new DataColumn();
            profile.Columns.Add(c1);
            profile.Columns.Add(c2);

            Team.generateProfile(profile,dt);
            
            dgvProfile.DataSource = profile;
            Team.formatProfile(dgvProfile);
            dgvProfile.Visible = true;
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
