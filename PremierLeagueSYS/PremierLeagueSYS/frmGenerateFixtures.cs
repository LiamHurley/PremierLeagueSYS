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
    public partial class frmGenerateFixtures : Form
    {
        public frmGenerateFixtures()
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

            if (dialog1 == DialogResult.Yes)
            {
                frmMainMenu form2 = new frmMainMenu();
                form2.ShowDialog();
                this.Close();
            }
            
        }

        private void btnGenFixtures_Click(object sender, EventArgs e)
        {
            Boolean fixturesAlreadyGenerated = false;
            int teamsInLeague = 20;

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to generate fixtures for the Premier League?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog1 == DialogResult.Yes) 
            {
                if (!fixturesAlreadyGenerated && teamsInLeague == 20)
                {
                    MessageBox.Show("Fixtures for the upcoming Premier League season have been generated successfully!", "Fixtures", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if(!fixturesAlreadyGenerated && teamsInLeague!=20)
                {
                    MessageBox.Show("Fixtures may not be generated when there are fewer than 20 teams in the Premier League", "Fixtures", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else if(fixturesAlreadyGenerated)
                {
                    MessageBox.Show("Fixtures for the upcoming season have already been generated!","Fixtures",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
                

            
        }
    }
}
