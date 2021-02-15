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
    public partial class frmScheduleFixture : Form
    {
        public frmScheduleFixture()
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

        private void btnSelectTeam_Click(object sender, EventArgs e)
        {
            Boolean fixturesGenerated = true;

            if (!fixturesGenerated)
            {
                MessageBox.Show("Fixtures have not yet been generated", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                cboSelectTeam.Hide();
                lblSelectTeam.Hide();
                btnSelectTeam.Hide();
                cboSelectFixture.Show();
                lblSelectFixture.Show();
                btnSelectFixture.Show();

                String selectedTeam = cboSelectTeam.SelectedItem.ToString();

                if(selectedTeam.Equals("Manchester United"))
                {
                    cboSelectFixture.Items.Add(selectedTeam +" vs Everton");
                    cboSelectFixture.Items.Add(selectedTeam + " vs Aston Villa");
                    cboSelectFixture.Items.Add("Liverpool vs " + selectedTeam);
                    cboSelectFixture.Items.Add("Manchester United vs " + selectedTeam);
                }
            }
            

        }

        private void frmScheduleFixture_Load(object sender, EventArgs e)
        {
            cboSelectFixture.Hide();
            lblSelectFixture.Hide();
            btnSelectFixture.Hide();
        }

        private void btnSelectFixture_Click(object sender, EventArgs e)
        {
            String selectedFixture = cboSelectFixture.SelectedItem.ToString();
            
            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to schedule " + selectedFixture + "?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog1 == DialogResult.Yes)
            {
                frmScheduleFixture2 form2 = new frmScheduleFixture2();
                form2.ShowDialog();
                this.Close();
            }
        }
    }
}
