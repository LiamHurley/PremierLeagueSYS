using System;
using System.Data;
using System.Windows.Forms;

namespace PremierLeagueSYS
{
    public partial class frmGenerateLeagueTable : Form
    {
        private frmMainMenu parent;
        
        public frmGenerateLeagueTable()
        {
            InitializeComponent();
        }
        public frmGenerateLeagueTable(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to generate the current league table?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog1 != DialogResult.Yes)
                return;

            lblGenerate.Hide();

            DataTable dt = new DataTable();
            dt.Columns.Add("Position", typeof(Int32));
            dt.Columns["Position"].AutoIncrement = true;
            dt.Columns["Position"].AutoIncrementSeed = 1;
            dt.Columns["Position"].AutoIncrementStep = 1;

            //learned how to load data from database into existing datatable using datatablereader here https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable.load?view=net-5.0
            DataTableReader reader = new DataTableReader(Team.generateTable());

            dt.Load(reader);

            dgvTable.DataSource = dt;
            Team.formatTable(dgvTable);
            dgvTable.Visible = true;
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
