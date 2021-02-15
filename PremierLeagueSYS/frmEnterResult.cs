﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PremierLeagueSYS
{
    public partial class frmEnterResult : Form
    {
        private frmMainMenu parent;
        private Fixture f = new Fixture();
        
        public frmEnterResult()
        {
            InitializeComponent();
        }
        public frmEnterResult(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmEnterResult_Load(object sender, EventArgs e)
        {
            if (!Fixture.fixturesExist())
            {
                MessageBox.Show("Fixtures for the new season have not yet been generated!\n\nReturning to main menu.");
                this.Close();
                parent.Visible = true;
            }

            DataTable teamsList = Team.getTeams();

            for (int i = 0; i < teamsList.Rows.Count; i++)
            {
                cboSelectTeam.Items.Add(teamsList.Rows[i]["NAME"].ToString());
            }
        }
        
        private void cboSelectTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            cboSelectFixture.Items.Clear();
            String selectedTeam = cboSelectTeam.SelectedItem.ToString();
            int id = Team.getTeamId(selectedTeam);
            DataTable dt = Fixture.getFixtures(id);

            foreach (DataRow dr in dt.Rows)
                cboSelectFixture.Items.Add(Convert.ToInt32(dr["FIX_ID"]).ToString("000") + " - " + dr["HomeTeam"].ToString() + " vs " + dr["AwayTeam"].ToString());
        }

        private void btnSelectFixture_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSelectTeam.Text) || string.IsNullOrEmpty(cboSelectFixture.Text))
            {
                MessageBox.Show("You must select a team and a fixture to proceed.");
                return;
            }

            String idStr = cboSelectFixture.Text.Substring(0, 3);

            if(idStr.Substring(0,2).Equals("00"))
            {
                idStr = idStr.Remove(0, 2);
            }
            else if(idStr[0]=='0' && idStr[1]!='0')
            {
                idStr = idStr.Remove(0, 1);
            }
            
            int id = Convert.ToInt32(idStr);

            if (!Fixture.isGamePlayed(id))
            {
                MessageBox.Show("You may not enter a result for a game that has not yet been played!");
                return;
            }

            DialogResult dialog1 = MessageBox.Show("Are you sure you wish to enter a result for " + cboSelectFixture.Text.Substring(6) + "?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog1==DialogResult.Yes)
            {
                lblHomeGoals.Show();
                lblAwayGoals.Show();
                txtHomeGoals.Show();
                txtAwayGoals.Show();
                btnSubmitResult.Show();
                btnSelectFixture.Hide();
                cboSelectTeam.Enabled = false;
                cboSelectFixture.Enabled = false;
            }
        }

        private void btnSubmitResult_Click(object sender, EventArgs e)
        {
            // isNumber method https://stackoverflow.com/a/894271

            Boolean isNumberHome = int.TryParse(txtHomeGoals.Text, out int homeGoalsParsed);
            Boolean isNumberAway = int.TryParse(txtAwayGoals.Text, out int awayGoalsParsed);

            if (string.IsNullOrEmpty(txtHomeGoals.Text) || string.IsNullOrEmpty(txtAwayGoals.Text))
            {
                MessageBox.Show("Fields cannot be left blank!");
                return;
            }

            if (!isNumberHome || !isNumberAway)
            {
                MessageBox.Show("Values must be whole numbers.");
                return;
            }

            if(homeGoalsParsed < 0 || homeGoalsParsed > 12 || awayGoalsParsed < 0 || awayGoalsParsed > 12)
            {
                MessageBox.Show("Values must be between 0 and 12 inclusive.");
                return;
            }

            else
            {
                f.id = Convert.ToInt32(cboSelectFixture.Text.Substring(0,3));
                f.homeGoals = homeGoalsParsed;
                f.awayGoals = awayGoalsParsed;

                f.updateResult();

                MessageBox.Show("You have successfully entered a result for "+cboSelectFixture.Text.Substring(6)+".\n\nThe result you entered was " +
                                 homeGoalsParsed+"-"+awayGoalsParsed+".\n\nBoth teams' stats have been updated and can be viewed via the Team Profile" +
                                 " or League Table!");

                lblHomeGoals.Hide();
                lblAwayGoals.Hide();
                txtHomeGoals.Hide();
                txtAwayGoals.Hide();
                txtHomeGoals.Clear();
                txtAwayGoals.Clear();
                btnSubmitResult.Hide();
                btnSelectFixture.Show();
                cboSelectFixture.Items.Remove(cboSelectFixture.SelectedItem);
                cboSelectTeam.Enabled = true;
                cboSelectFixture.Enabled = true;
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
                Application.Exit();
        }
    }
}