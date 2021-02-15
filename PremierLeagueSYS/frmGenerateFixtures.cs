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
    public partial class frmGenerateFixtures : Form
    {
        private frmMainMenu parent;
        
        public frmGenerateFixtures()
        {
            InitializeComponent();
        }

        public frmGenerateFixtures(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmGenerateFixtures_Load(object sender, EventArgs e)
        {
            /*int teams = Team.countTeams();
            
            if (teams != 20)
            {
                MessageBox.Show("There are currently only " + teams + " teams in the Premier League.  There must be exactly 20 teams before fixtures may be generated." +
                    "\n\nPlease add " + (20-teams) + " more teams and try again.");
                Application.Exit();
            }*/
        }

        private void btnGenFixtures_Click(object sender, EventArgs e)
        {
            if (Fixture.fixturesExist())
            {
                MessageBox.Show("Fixtures for the season have already been generated!", "Fixtures", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to generate fixtures for the Premier League?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                Fixture.generate();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
                parent.Visible = true;
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
    }
}
