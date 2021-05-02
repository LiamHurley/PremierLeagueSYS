using System;
using System.Windows.Forms;

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
            if (Fixture.fixturesExist())
            {
                MessageBox.Show("Fixtures for the season have already been generated!\n\nReturning to main menu.", "Fixtures", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Visible = true;
                return;
            }

            int teams = Team.countTeams();
            
            if (teams != 6)
            {
                MessageBox.Show("There are currently only " + teams + " teams in the Premier League.  There must be exactly 6 teams before fixtures may be generated." +
                    "\n\nPlease add " + (6-teams) + " more teams and try again.\n\nNow returning to main menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Visible = true;
            }
        }

        private void btnGenFixtures_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to generate fixtures for the Premier League?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                try
                {
                    Fixture.generate();
                }
                catch
                {
                    MessageBox.Show("Error encountered while attempting to generate fixtures.\n\nApplication will now return to the main menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    parent.Visible = true;
                }
                
                MessageBox.Show("Fixtures for the Premier League have been successfully generated! \n\nYou are now able to schedule fixtures!" +
                    "\n\nReturning to main menu.");
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
    }
}
