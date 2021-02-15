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
            DataTable teamsList = Team.getTeams();

            for (int i = 0; i < teamsList.Rows.Count; i++)
            {
                cboSelectTeam.Items.Add(Convert.ToInt32(teamsList.Rows[i]["TEAM_ID"]).ToString("000")+" - "+teamsList.Rows[i]["NAME"].ToString());
            }
        }

        private void cboSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idStr = cboSelectTeam.Text.Substring(0, 3);

            if (idStr.Substring(0, 2).Equals("00"))
            {
                idStr = idStr.Remove(0, 2);
            }
            else if (idStr[0] == '0' && idStr[1] != '0')
            {
                idStr = idStr.Remove(0, 1);
            }

            DataTable dt = Team.generateProfile(Convert.ToInt32(idStr));

            DataTable profile = new DataTable();

            DataColumn c1 = new DataColumn();
            DataColumn c2 = new DataColumn();
            profile.Columns.Add(c1);
            profile.Columns.Add(c2);

            profile.Rows.Add("Team Name", dt.Rows[0]["NAME"].ToString());

            if (Convert.ToInt32(dt.Rows[0]["HomeGames"]) != 0)
                profile.Rows.Add("Average Home Goals", (Convert.ToDecimal(dt.Rows[0]["HomeGoals"]) / Convert.ToDecimal(dt.Rows[0]["HomeGames"])).ToString("0.00"));
            else
                profile.Rows.Add("Average Home Goals", "0");

            if (Convert.ToInt32(dt.Rows[0]["AwayGames"]) != 0)
                profile.Rows.Add("Average Away Goals", (Convert.ToDecimal(dt.Rows[0]["AwayGoals"]) / Convert.ToDecimal(dt.Rows[0]["AwayGames"])).ToString("0.00"));
            else
                profile.Rows.Add("Average Away Goals", "0");

            if (Convert.ToInt32(dt.Rows[0]["PLAYED"]) != 0 && (Convert.ToInt32(dt.Rows[0]["HomeGoals"]) + Convert.ToInt32(dt.Rows[0]["AwayGoals"]) > 0))
                profile.Rows.Add("Minutes Per Goal", ((Convert.ToDecimal(dt.Rows[0]["PLAYED"]) * 90) / (Convert.ToDecimal(dt.Rows[0]["HomeGoals"]) + Convert.ToDecimal(dt.Rows[0]["AwayGoals"]))).ToString("0.00"));
            else
                profile.Rows.Add("Minutes Per Goal", "0.00");

            if (Convert.ToInt32(dt.Rows[0]["HomeGames"]) != 0)
                profile.Rows.Add("Home Win %", ((Convert.ToDecimal(dt.Rows[0]["HomeWins"]) / Convert.ToDecimal(dt.Rows[0]["HomeGames"])) * 100).ToString("0.00") + "%");
            else
                profile.Rows.Add("Home Win %", "0.00%");

            if (Convert.ToInt32(dt.Rows[0]["AwayGames"]) != 0)
                profile.Rows.Add("Away Win %", ((Convert.ToDecimal(dt.Rows[0]["AwayWins"]) / Convert.ToDecimal(dt.Rows[0]["AwayGames"])) * 100).ToString("0.00") + "%");
            else
                profile.Rows.Add("Away Win %", "0.00%");

            if (Convert.ToInt32(dt.Rows[0]["PLAYED"]) != 0)
                profile.Rows.Add("Points Per Game", (Convert.ToDecimal(dt.Rows[0]["POINTS"]) / Convert.ToDecimal(dt.Rows[0]["PLAYED"])).ToString("0.00"));
            else
                profile.Rows.Add("Points Per Game", "0");

            profile.Rows.Add("Clean Sheets", dt.Rows[0]["CleanSheets"]);

            dgvProfile.DataSource = profile;
            Team.formatProfile(dgvProfile);
            dgvProfile.Visible = true;
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
                this.Close();
                parent.Visible = true;
            }
        }
    }
}
