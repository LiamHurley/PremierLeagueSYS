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
    public partial class frmViewResults : Form
    {
        private frmMainMenu parent;
        
        public frmViewResults()
        {
            InitializeComponent();
        }

        public frmViewResults(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmViewResults_Load(object sender, EventArgs e)
        {
            if (!Fixture.fixturesExist())
            {
                MessageBox.Show("Fixtures for the new season have not yet been generated!\n\nReturning to main menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Visible = true;
            }

            Team.loadTeams(cboSelectTeam);
            Fixture.loadGameweeks(cboGameweeks);
        }

        private void cboSelectTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSelectTeam.SelectedIndex == -1)
                return;

            if (cboGameweeks.SelectedIndex != -1)
                cboGameweeks.SelectedIndex = -1;
            
            rtbResults.Clear();

            DataTable dt = Fixture.getAllFixtures(Convert.ToInt32(Utility.deformatId(cboSelectTeam.Text.Substring(0, 3))));

            Fixture.loadTeamResults(dt, rtbResults);

            rtbResults.Visible = true;
        }

        private void cboGameweeks_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboGameweeks.SelectedIndex == -1)
                return;
            
            if (cboSelectTeam.SelectedIndex != -1)
                cboSelectTeam.SelectedIndex = -1;
            
            rtbResults.Clear();

            DataTable dt = Fixture.getFixByGameweek(Convert.ToInt32(cboGameweeks.Text));

            Fixture.loadGameweekResults(dt, rtbResults);

            rtbResults.Visible = true;
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
