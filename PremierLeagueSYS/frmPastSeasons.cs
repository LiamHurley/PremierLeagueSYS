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
    public partial class frmPastSeasons : Form
    {
        private frmMainMenu parent;
        
        public frmPastSeasons()
        {
            InitializeComponent();
        }

        public frmPastSeasons(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmPastSeasons_Load(object sender, EventArgs e)
        {
            DataTable seasons = Team.loadSeasons();

            if(seasons.Rows.Count==0)
            {
                MessageBox.Show("No previous seasons were found.\n\nReturning to the main menu.");
                this.Close();
                parent.Visible = true;
                return;
            }

            for (int i = 0; i < seasons.Rows.Count; i++)
            {
                cboSelectSeason.Items.Add(Convert.ToInt32(seasons.Rows[i]["TABLE_NAME"].ToString().Substring(6))-1 +"/"+ seasons.Rows[i]["TABLE_NAME"].ToString().Substring(6));
            }
        }

        private void cboSelectSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Position", typeof(Int32));
            dt.Columns["Position"].AutoIncrement = true;
            dt.Columns["Position"].AutoIncrementSeed = 1;
            dt.Columns["Position"].AutoIncrementStep = 1;

            DataTableReader reader = new DataTableReader(Team.loadPastTable(Convert.ToInt32(cboSelectSeason.Text.Substring(5))));

            dt.Load(reader);

            dgvTable.DataSource = dt;
            Team.formatTable(dgvTable);
            dgvTable.Visible = true;
        }

        private void mnuRemoveTeamBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to return to the main menu?", "Confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
            {
                this.Close();
                parent.Visible = true;
            }
        }

        private void mnuRemoveTeamExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }
    }
}
