using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace PremierLeagueSYS
{
    class Team
    {
        //learned to write getters and setters like this here https://codeasy.net/lesson/properties

        public int id { get; set; }
        public String name { get; set; }
        public String manager { get; set; }
        public String stadium { get; set; }
        public int capacity { get; set; }
        public String location { get; set; }
        public int points { get; set; }
        public int won { get; set; }
        public int drawn { get; set; }
        public int lost { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }
        private OracleConnection conn = new OracleConnection(DBConnect.oraDB);

        public Team()
        {
            this.name = "";
            this.manager = "";
            this.stadium = "";
            this.capacity = 0;
            this.location = "";
        }

        public Team(String name, String manager, String stadium, int capacity, String location)
        {
            this.id = getNextId();
            this.name = name;
            this.manager = manager;
            this.stadium = stadium;
            this.capacity = capacity;
            this.location = location;
        }

        public static bool teamExists(String teamName)
        {
            String sql = "SELECT * FROM TEAMS WHERE LOWER(NAME) = :name";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":name", teamName);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public static bool managerExists(String manager)
        {
            String sql = "SELECT * FROM TEAMS WHERE LOWER(MANAGER) = :manager";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":manager", manager);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public static int countTeams()
        {
            String sql = "SELECT * FROM TEAMS";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt.Rows.Count;
        }


        public void addTeam()
        {
            String sql = "INSERT INTO TEAMS(TEAM_ID,NAME,MANAGER,STADIUM,STADIUM_CAPACITY,LOCATION)" +
                                                 "VALUES (:id,:name,:manager,:stad,:cap,:location)";

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", this.id);
            cmd.Parameters.Add(":name", this.name);
            cmd.Parameters.Add(":manager", this.manager);
            cmd.Parameters.Add(":stad", this.stadium);
            cmd.Parameters.Add(":cap", this.capacity);
            cmd.Parameters.Add(":location", this.location);

            conn.Open();

            cmd.ExecuteNonQuery();
            
            conn.Close();
        }

        public static int getNextId()
        {
            String sql = "SELECT max(TEAM_ID) FROM TEAMS";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            if (string.IsNullOrEmpty(dt.Rows[0]["MAX(TEAM_ID)"].ToString()))
                return 0;

            return Int32.Parse(dt.Rows[0]["MAX(TEAM_ID)"].ToString())+1;
        }

        public void getTeamInfo(int id)
        {
            this.id = id;

            String sql = "SELECT * FROM TEAMS WHERE TEAM_ID=:id";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", id);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.name = dr.GetString(1);
            this.manager = dr.GetString(2);
            this.stadium = dr.GetString(3);
            this.capacity = dr.GetInt32(4);
            this.location = dr.GetString(5);

            conn.Close();
        }
        
        public static DataTable loadTeams()
        {
            String sql = "SELECT * FROM TEAMS ORDER BY NAME ASC";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        //loads Team objects into supplied ComboBox
        public static void loadTeams(ComboBox cbo)
        {
            DataTable teamsList = Team.loadTeams(); 
            
            for (int i = 0; i < teamsList.Rows.Count; i++)
            {
                cbo.Items.Add(Convert.ToInt32(teamsList.Rows[i]["TEAM_ID"]).ToString("000") + " - " + teamsList.Rows[i]["NAME"].ToString());
            }
        }

        public void removeTeam()
        {
            String sql = "DELETE FROM TEAMS WHERE TEAM_ID = '" + this.id + "'";

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("You have successfully removed " + this.name + " from the Premier League!");

            conn.Close();
        }

        public void updateTeam()
        {
            String sql = "UPDATE TEAMS SET MANAGER=:manager, STADIUM=:stadium,STADIUM_CAPACITY=:capacity,LOCATION=:location WHERE TEAM_ID =:id";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":manager", this.manager);
            cmd.Parameters.Add(":stadium", this.stadium);
            cmd.Parameters.Add(":capacity", this.capacity);
            cmd.Parameters.Add(":location", this.location);
            cmd.Parameters.Add(":id", this.id);

            cmd.ExecuteNonQuery();
            MessageBox.Show("You have successfully updated " + this.name + "'s details!");

            conn.Close();
        }

        public static DataTable getProfileStats(int id)
        {
            //learned how to execute multiple counts in one query here https://stackoverflow.com/questions/12789396/how-to-get-multiple-counts-with-one-sql-query

            String sql = "SELECT NAME, COALESCE(POINTS,0) as POINTS, COALESCE(PLAYED,0) as PLAYED," +
                "(SELECT COUNT(*) FROM FIXTURES WHERE HOME_TEAM_ID=:id AND HOME_GOALS > AWAY_GOALS) as HomeWins," +
                "(SELECT COUNT(*) FROM FIXTURES WHERE HOME_TEAM_ID=:id AND HOME_GOALS IS NOT NULL) as HomeGames," +
                "(SELECT COALESCE(SUM(HOME_GOALS),0) FROM FIXTURES WHERE HOME_TEAM_ID =:id) as HomeGoals," +
                "(SELECT COUNT(*) FROM FIXTURES WHERE AWAY_TEAM_ID=:id AND AWAY_GOALS > HOME_GOALS) as AwayWins," +
                "(SELECT COUNT(*) FROM FIXTURES WHERE AWAY_TEAM_ID=:id AND HOME_GOALS IS NOT NULL) as AwayGames," +
                "(SELECT COALESCE(SUM(AWAY_GOALS),0) FROM FIXTURES WHERE AWAY_TEAM_ID =:id) as AwayGoals," +
                "(SELECT COUNT(*) FROM FIXTURES WHERE HOME_TEAM_ID=:id AND AWAY_GOALS=0 OR AWAY_TEAM_ID=:id AND HOME_GOALS=0) as CleanSheets" +
                " FROM TEAMS WHERE TEAM_ID=:id";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", id);
            
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public static int getTeamId(String name)
        {
            int id = 0;

            String sql = "SELECT TEAM_ID FROM TEAMS WHERE NAME = :name";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":name", name);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Teams");

            DataTable dt = ds.Tables["Teams"];

            conn.Close();

            foreach (DataRow dr in dt.Rows)
                id = Int32.Parse(dr["TEAM_ID"].ToString());

            return id;
        }

        // NOTE - Expand following few methods?
        
        public static void homeWin(int id)
        {
            String sql = "SELECT HOME_TEAM_ID, AWAY_TEAM_ID, HOME_GOALS, AWAY_GOALS FROM FIXTURES WHERE FIX_ID=:id";
            int winningTeam = 0, losingTeam = 0, goalsFor = 0, goalsA = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", id);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                winningTeam = Convert.ToInt32(dr["HOME_TEAM_ID"].ToString());
                losingTeam = Convert.ToInt32(dr["AWAY_TEAM_ID"].ToString());
                goalsFor = Convert.ToInt32(dr["HOME_GOALS"].ToString());
                goalsA = Convert.ToInt32(dr["AWAY_GOALS"].ToString());
            }

            String sqlStr = "UPDATE TEAMS SET PLAYED=Coalesce(PLAYED, 0)+1, WON=Coalesce(WON, 0)+1, GOALS_FOR=Coalesce(GOALS_FOR, 0)+'" + goalsFor + "'," +
                            "GOALS_AGAINST=Coalesce(GOALS_AGAINST, 0)+'" + goalsA + "', POINTS=Coalesce(POINTS, 0)+3, " +
                            "GOAL_DIFFERENCE=Coalesce(GOAL_DIFFERENCE,0)+'"+(goalsFor-goalsA)+"' WHERE TEAM_ID=:id";

            conn.Open();

            OracleCommand cmdHome = new OracleCommand(sqlStr, conn);
            cmdHome.Parameters.Add(":id", winningTeam);

            cmdHome.ExecuteNonQuery();

            conn.Close();

            sqlStr = "UPDATE TEAMS SET PLAYED=Coalesce(PLAYED, 0)+1, LOST=Coalesce(LOST, 0)+1, GOALS_FOR=Coalesce(GOALS_FOR, 0)+'" + goalsA + "'," +
                     "GOALS_AGAINST=Coalesce(GOALS_AGAINST, 0)+'" + goalsFor + "', POINTS=Coalesce(POINTS,0)+0, " +
                     "GOAL_DIFFERENCE=Coalesce(GOAL_DIFFERENCE,0)+'" + (goalsA - goalsFor) + "' WHERE TEAM_ID=:id";

            conn.Open();

            OracleCommand cmdAway = new OracleCommand(sqlStr, conn);
            cmdAway.Parameters.Add(":id", losingTeam);

            cmdAway.ExecuteNonQuery();

            conn.Close();
        }

        public static void awayWin(int id)
        {
            String sql = "SELECT HOME_TEAM_ID, AWAY_TEAM_ID, HOME_GOALS, AWAY_GOALS FROM FIXTURES WHERE FIX_ID=:id";
            int winningTeam = 0, losingTeam = 0, goalsFor = 0, goalsA = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", id);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                losingTeam = Convert.ToInt32(dr["HOME_TEAM_ID"].ToString());
                winningTeam = Convert.ToInt32(dr["AWAY_TEAM_ID"].ToString());
                goalsA = Convert.ToInt32(dr["HOME_GOALS"].ToString());
                goalsFor = Convert.ToInt32(dr["AWAY_GOALS"].ToString());
            }

            String sqlStr = "UPDATE TEAMS SET PLAYED=Coalesce(PLAYED, 0)+1, WON=Coalesce(WON, 0)+1, GOALS_FOR=Coalesce(GOALS_FOR, 0)+'" + goalsFor + "'," +
                            "GOALS_AGAINST=Coalesce(GOALS_AGAINST, 0)+'" + goalsA + "', POINTS=Coalesce(POINTS, 0)+3, " +
                            "GOAL_DIFFERENCE=Coalesce(GOAL_DIFFERENCE,0)+'" + (goalsFor - goalsA) + "' WHERE TEAM_ID=:id";

            conn.Open();

            OracleCommand cmdHome = new OracleCommand(sqlStr, conn);
            cmdHome.Parameters.Add(":id", winningTeam);

            cmdHome.ExecuteNonQuery();

            conn.Close();

            sqlStr = "UPDATE TEAMS SET PLAYED=Coalesce(PLAYED, 0)+1, LOST=Coalesce(LOST, 0)+1, GOALS_FOR=Coalesce(GOALS_FOR, 0)+'" + goalsA + "'," +
                            "GOALS_AGAINST=Coalesce(GOALS_AGAINST, 0)+'" + goalsFor + "', POINTS=Coalesce(POINTS,0)+0, " +
                            "GOAL_DIFFERENCE=Coalesce(GOAL_DIFFERENCE,0)+'" + (goalsA - goalsFor) + "' WHERE TEAM_ID=:id";

            conn.Open();

            OracleCommand cmdAway = new OracleCommand(sqlStr, conn);
            cmdAway.Parameters.Add(":id", losingTeam);

            cmdAway.ExecuteNonQuery();

            conn.Close();
        }

        public static void draw(int id)
        {
            String sql = "SELECT HOME_TEAM_ID, AWAY_TEAM_ID, HOME_GOALS FROM FIXTURES WHERE FIX_ID=:id";
            int goals = 0, homeTeam=0, awayTeam=0;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", id);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                goals = Convert.ToInt32(dr["HOME_GOALS"].ToString());
                homeTeam = Convert.ToInt32(dr["HOME_TEAM_ID"].ToString());
                awayTeam = Convert.ToInt32(dr["AWAY_TEAM_ID"].ToString());
            }

            String sqlStr = "UPDATE TEAMS SET PLAYED=Coalesce(PLAYED, 0)+1, DRAWN=Coalesce(DRAWN, 0)+1, GOALS_FOR=Coalesce(GOALS_FOR, 0)+'" + goals + "'," +
                           "GOALS_AGAINST=Coalesce(GOALS_AGAINST, 0)+'" + goals + "', POINTS=Coalesce(POINTS, 0)+1, " +
                           "GOAL_DIFFERENCE=Coalesce(GOAL_DIFFERENCE,0)+0 WHERE TEAM_ID=:htid OR TEAM_ID=:atid";

            conn.Open();

            OracleCommand cmdHome = new OracleCommand(sqlStr, conn);
            cmdHome.Parameters.Add(":htid", homeTeam);
            cmdHome.Parameters.Add(":atid", awayTeam);
            
            cmdHome.ExecuteNonQuery();

            conn.Close();
        }

        public static DataTable generateTable()
        {
            String sql = "SELECT NAME, COALESCE(PLAYED,0) as P, COALESCE(WON,0) as W, COALESCE(DRAWN,0) as D, COALESCE(LOST,0) as L, COALESCE(GOALS_FOR,0) as GF, " +
                         "COALESCE(GOALS_AGAINST,0) as GA, COALESCE(GOAL_DIFFERENCE,0) as GD, COALESCE(POINTS,0) as Pts FROM TEAMS ORDER BY Pts DESC, GD DESC, GF DESC, NAME ASC";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public static void formatTable(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 20;
            
            for (int i=0; i<dgv.Columns.Count; i++)
            {
                if (i != 1)
                {
                    dgv.Columns[i].Width = 60;
                }
            }
        }
        
        public static void formatProfile(DataGridView dgvProfile)
        {
            dgvProfile.Columns[0].Width = 150;
            dgvProfile.Columns[1].Width = 150;
            dgvProfile.Enabled = false;
            dgvProfile.ColumnHeadersVisible = false;
            dgvProfile.AllowUserToAddRows = false;
        }

        public static bool isSeasonComplete()
        {
            String sql = "SELECT PLAYED FROM TEAMS";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            for(int i=0; i<dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["PLAYED"]) != 10)
                    return false;
            }

            return true;
        }

        public static void saveSeason(int endYear)
        {
            String sql = "CREATE TABLE Teams_" + endYear + " AS SELECT * FROM TEAMS";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Method to sort league Table to determine who to relegate
        //different to generateTable() as this method also selects TeamID so they can be renumbered in new season module.
        public static DataTable sortTable()
        {
            String sql = "SELECT TEAM_ID, NAME, COALESCE(PLAYED,0) as P, COALESCE(WON,0) as W, COALESCE(DRAWN,0) as D, COALESCE(LOST,0) as L, COALESCE(GOALS_FOR,0) as GF, " +
                           "COALESCE(GOALS_AGAINST,0) as GA, COALESCE(GOAL_DIFFERENCE,0) as GD, COALESCE(POINTS,0) as Pts FROM TEAMS ORDER BY Pts DESC, GD DESC, GF DESC, NAME ASC";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public static void relegate(List<int> teams)
        {
            String sql = "DELETE FROM TEAMS WHERE TEAM_ID=" + teams[0] + " or TEAM_ID=" + teams[1] +
                         " or TEAM_ID=" + teams[2];

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void getRemainingIds()
        {
            String sql = "SELECT TEAM_ID FROM TEAMS ORDER BY TEAM_ID ASC";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            for(int i=0; i<dt.Rows.Count; i++)
            {
                if(Convert.ToInt32(dt.Rows[i]["TEAM_ID"]) != i+1)
                {
                    renumber(Convert.ToInt32(dt.Rows[i]["TEAM_ID"]), i+1);
                }
            }
        }

        //Method for renumbering remaining 17 teams 1-17 after relegation has taken place.
        public static void renumber(int id, int newId)
        {
            String sql = "UPDATE TEAMS SET TEAM_ID=:newId WHERE TEAM_ID=:id";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":newId",newId);
            cmd.Parameters.Add(":id",id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void resetStats()
        {
            String sql = "UPDATE TEAMS SET PLAYED=null,WON=null,DRAWN=null,LOST=null,GOALS_FOR=null,GOALS_AGAINST=null,POINTS=null,GOAL_DIFFERENCE=null";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int getLastYear()
        {
            String sql = "select table_name from user_tables where table_name LIKE 'TEAMS%' ORDER BY table_name";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            if (dt.Rows.Count == 1)
            {
                return 2021;
            }

            DataRow row = dt.Rows[dt.Rows.Count - 1];

            return Convert.ToInt32(row["TABLE_NAME"].ToString().Substring(6));
        }

        public static DataTable loadPastSeasons()
        {
            String sql = "select table_name from user_tables where table_name LIKE 'TEAMS_%' ORDER BY table_name";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public static DataTable loadPastTable(int year)
        {
            String sql = "SELECT NAME, COALESCE(PLAYED,0) as P, COALESCE(WON,0) as W, COALESCE(DRAWN,0) as D, COALESCE(LOST,0) as L, COALESCE(GOALS_FOR,0) as GF, " +
                         "COALESCE(GOALS_AGAINST,0) as GA, COALESCE(GOAL_DIFFERENCE,0) as GD, COALESCE(POINTS,0) as Pts FROM TEAMS_"+year+" ORDER BY Pts DESC, GD DESC, GF DESC, NAME ASC";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public static bool isNumeric(String Expression)
        {
            // code taken from https://stackoverflow.com/questions/894263/identify-if-a-string-is-a-number 

            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static void generateProfile(DataTable profile, DataTable dt)
        {
            profile.Rows.Add("Team Name", dt.Rows[0]["NAME"].ToString());
            profile.Rows.Add("Games Played", dt.Rows[0]["PLAYED"].ToString());
            
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
        }
    }
}
