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
    public partial class frmNewSeason : Form
    {
        private frmMainMenu parent;
        
        public frmNewSeason()
        {
            InitializeComponent();
        }

        public frmNewSeason(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmNewSeason_Load(object sender, EventArgs e)
        {
            /*if(!Team.isSeasonComplete())
            {
                MessageBox.Show("You may not start a new season whilst one is currently in progress.\n\nReturning to main menu.");
                this.Close();
                parent.Visible = true;
            }*/
        }

        private void btnNewSeason_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you wish to start a new Premier League season?\n\nThis action will save and clear all fixtures, statistics and standings from" +
                " the current season.","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog != DialogResult.Yes)
                return;

            if(!Fixture.hasTimeElapsed())
            {
                MessageBox.Show("You may not start a new season so soon after the current one has ended.\n\nReturning to main menu.");
                this.Close();
                parent.Visible = true;
                return;
            }

            int endYear = Fixture.getEndYear();

            Team.saveSeason(endYear);
                
            DataTable table = Team.sortTable();

            List<int> relegatedIds = new List<int>();

            for(int i = table.Rows.Count-1; i >= table.Rows.Count-3; i--)
            {
                relegatedIds.Add(Convert.ToInt32(table.Rows[i]["TEAM_ID"]));
            }

            Fixture.clear();

            Team.relegate(relegatedIds);

            Team.getRemainingIds(); //call to renumber() method inside getRemainingIds()

            Team.resetStats();

            MessageBox.Show("New season successfully created.\n\nThe new season will commence in August "+endYear+".\n\nApplication will now return to the main menu.");
            this.Close();
            parent.Visible = true;

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
