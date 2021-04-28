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
    class Fixture
    {
        //learned to write getters and setters like this here https://codeasy.net/lesson/properties
        
        public int id { get; set; }
        public int gameweek { get; set; }
        public int homeTeamId { get; set; }
        public int awayTeamId { get; set; }
        public String date { get; set; }
        public String time { get; set; }
        public int homeGoals { get; set; }
        public int awayGoals { get; set; }
        private OracleConnection conn = new OracleConnection(DBConnect.oraDB);

        public Fixture()
        {}
        
        public Fixture(int gameweek, int homeTeamId, int awayTeamId)
        {
            this.id = getNextId();
            this.gameweek = gameweek;
            this.homeTeamId = homeTeamId;
            this.awayTeamId = awayTeamId;
        }

        public static bool fixturesExist()
        {
            String sql = "SELECT * FROM FIXTURES";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

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

        public static void generate()
        {

            /*****************************************************
            *    Title: Tournament Schedule Generator Code PHP
            *    Author: Coding
            *    Lines: 75-102, 111-123
            *    Site owner/sponsor: youtube.com
            *    Date: 2017
            *    Code version: edited Nov 24 2017
            *    Availability: https://youtu.be/tMQptqtTrpM
            *    Modified:  Converted from PHP to C#
            *****************************************************/

            DataTable dt = getAllIds();
            int[] ids = new int[dt.Rows.Count];
            int i = 0;
            int totalTeams = dt.Rows.Count;
            int weeks = dt.Rows.Count - 1;
            int team1, team2, temp;

            int[] homeTeams = new int[totalTeams];
            int[] awayTeams = new int[totalTeams];

            double dbl = (double)(totalTeams - 1) / 2;
            int matchesPerWeek = (int)Math.Round(dbl, MidpointRounding.AwayFromZero);

            foreach (DataRow row in dt.Rows)
            {
                ids[i] = Int32.Parse(row["TEAM_ID"].ToString());
                i++;
            }

            for (int j = 0; j < weeks; j++)
            {
                for (int k = 0; k < matchesPerWeek; k++)
                {
                    team1 = ids[matchesPerWeek - k - 1];
                    team2 = ids[matchesPerWeek + k];

                    homeTeams[j] = team1;
                    awayTeams[j] = team2;

                    //swap position of teams every other gameweek for more realistic looking fixture schedule
                    if (j % 2 == 0)
                    {
                        homeTeams[j] = team2;
                        awayTeams[j] = team1;
                    }

                    Fixture f = new Fixture(j + 1, homeTeams[j], awayTeams[j]);
                    f.insert();
                    f.revenge(weeks);
                }

                temp = ids[1];

                for (int l = 1; l < totalTeams - 1; l++)
                {
                    ids[l] = ids[l + 1];
                }

                ids[totalTeams - 1] = temp;

            }
        }

        public static DataTable getAllIds()
        {
            String sql = "SELECT TEAM_ID FROM TEAMS";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public void insert()
        {
            String sql = "INSERT INTO FIXTURES(FIX_ID,GAMEWEEK,HOME_TEAM_ID,AWAY_TEAM_ID) VALUES(:id,:gw,:htid,:atid)";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", this.id);
            cmd.Parameters.Add(":gw", this.gameweek);
            cmd.Parameters.Add(":htid", this.homeTeamId);
            cmd.Parameters.Add(":atid", this.awayTeamId);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int getNextId()
        {
            String sql = "SELECT max(FIX_ID) FROM FIXTURES";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            if (string.IsNullOrEmpty(dt.Rows[0]["MAX(FIX_ID)"].ToString()))
                return 1;

            return Int32.Parse(dt.Rows[0]["MAX(FIX_ID)"].ToString())+1;
        }

        public void revenge(int weeks)
        {
            Fixture f = new Fixture(this.gameweek + weeks, this.awayTeamId, this.homeTeamId);
            f.insert();
        }

        public static DataTable getUnscheduledFixtures(int id)
        {
            String sql = "SELECT FIX_ID, GAMEWEEK, h.TEAM_ID, h.NAME as HomeTeam, a.TEAM_ID, a.NAME as AwayTeam, FIX_DATE" +
                " FROM TEAMS h" +
                " JOIN FIXTURES f on h.TEAM_ID=f.HOME_TEAM_ID" +
                " JOIN TEAMS a on a.TEAM_ID=f.AWAY_TEAM_ID" +
                " WHERE (f.HOME_TEAM_ID = :id OR f.AWAY_TEAM_ID=:id) AND FIX_DATE IS NULL" +
                " ORDER BY HomeTeam,AwayTeam";

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

        public static DataTable getUnplayedFixtures(int id)
        {
            String sql = "SELECT FIX_ID, GAMEWEEK, h.TEAM_ID, h.NAME as HomeTeam, a.TEAM_ID, a.NAME as AwayTeam, FIX_DATE, HOME_GOALS" +
                " FROM TEAMS h" +
                " JOIN FIXTURES f on h.TEAM_ID=f.HOME_TEAM_ID" +
                " JOIN TEAMS a on a.TEAM_ID=f.AWAY_TEAM_ID" +
                " WHERE (f.HOME_TEAM_ID = :id OR f.AWAY_TEAM_ID=:id) AND FIX_DATE IS NOT NULL AND HOME_GOALS IS NULL" +
                " ORDER BY GAMEWEEK ASC";

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

        public static DataTable getAllFixtures(int id)
        {
            String sql = "SELECT FIX_ID, GAMEWEEK, h.TEAM_ID, h.NAME as HomeTeam, a.TEAM_ID, a.NAME as AwayTeam, FIX_DATE, FIX_TIME, HOME_GOALS, AWAY_GOALS" +
                " FROM TEAMS h" +
                " JOIN FIXTURES f on h.TEAM_ID=f.HOME_TEAM_ID" +
                " JOIN TEAMS a on a.TEAM_ID=f.AWAY_TEAM_ID" +
                " WHERE (f.HOME_TEAM_ID = :id OR f.AWAY_TEAM_ID=:id)" +
                " ORDER BY GAMEWEEK ASC";

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

        public static DataTable getFixByGameweek(int id)
        {
            String sql = "SELECT FIX_ID, GAMEWEEK, h.TEAM_ID, h.NAME as HomeTeam, a.TEAM_ID, a.NAME as AwayTeam, FIX_DATE, FIX_TIME, HOME_GOALS, AWAY_GOALS" +
                " FROM TEAMS h" +
                " JOIN FIXTURES f on h.TEAM_ID=f.HOME_TEAM_ID" +
                " JOIN TEAMS a on a.TEAM_ID=f.AWAY_TEAM_ID" +
                " WHERE GAMEWEEK =:id" +
                " ORDER BY FIX_ID ASC";

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

        public static void loadTeamResults(DataTable dt, RichTextBox rtb)
        {
            foreach (DataRow dr in dt.Rows)
                rtb.Text += "GW " + dr["GAMEWEEK"] + " - " + dr["HomeTeam"].ToString() + " " + dr["HOME_GOALS"].ToString() + " v " 
                             + dr["AWAY_GOALS"].ToString() + " " + dr["AwayTeam"].ToString() + "\n";
        }

        public static void loadGameweekResults(DataTable dt, RichTextBox rtb)
        {
            foreach (DataRow dr in dt.Rows)
                rtb.Text += dr["HomeTeam"].ToString() + " " + dr["HOME_GOALS"].ToString() + " v "
                            + dr["AWAY_GOALS"].ToString() + " " + dr["AwayTeam"].ToString() + "\n";
        }

        public static void loadFixtures(DataTable dt, ComboBox cbo)
        {
            foreach (DataRow dr in dt.Rows)
                cbo.Items.Add(Convert.ToInt32(dr["FIX_ID"]).ToString("000") + " - " + dr["HomeTeam"].ToString() + " vs " + dr["AwayTeam"].ToString());
        }

        public static String getFixDate(int id)
        {
            String sql = "SELECT FIX_DATE FROM FIXTURES WHERE FIX_ID =:id";
            String date = "";

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
                date = dr["FIX_DATE"].ToString();
            }

            return date;
        }

        public static String getFixTime(int id)
        {
            String sql = "SELECT FIX_TIME FROM FIXTURES WHERE FIX_ID =:id";
            String time = "";

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
                time = dr["FIX_TIME"].ToString();
            }

            return time;
        }

        public void schedule()
        {
            String sql = "UPDATE FIXTURES SET FIX_DATE=:dat, FIX_TIME=:time WHERE FIX_ID=:id";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":dat", this.date);
            cmd.Parameters.Add(":time", this.time);
            cmd.Parameters.Add(":id", this.id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        
        public static bool isValidDate(int id, String date)
        {
            List<int> ids = getIdsFromFixture(id);
            
            String sql = "SELECT * FROM FIXTURES WHERE FIX_DATE=:dat AND ((HOME_TEAM_ID=:home OR AWAY_TEAM_ID=:away) OR (HOME_TEAM_ID=:away OR AWAY_TEAM_ID=:home))";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB); 
            
            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":dat", date);
            cmd.Parameters.Add(":home", ids[0]);
            cmd.Parameters.Add(":away", ids[1]);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }
        }

        public void updateResult()
        {
            String sql = "UPDATE FIXTURES SET HOME_GOALS=:hg, AWAY_GOALS=:ag WHERE FIX_ID=:id";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":hg", this.homeGoals);
            cmd.Parameters.Add(":ag", this.awayGoals);
            cmd.Parameters.Add(":id", this.id);

            cmd.ExecuteNonQuery();

            conn.Close();

            if (this.homeGoals > this.awayGoals)
                Team.homeWin(this.id);
            else if (this.awayGoals > this.homeGoals)
                Team.awayWin(this.id);
            else
                Team.draw(this.id);
        }
        
        public static bool isGamePlayed(int id)
        {
            String sql = "SELECT FIX_DATE FROM FIXTURES WHERE FIX_ID=:id";
            String dateStr="";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", id);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            foreach(DataRow dr in dt.Rows)
            {
                dateStr = dr["FIX_DATE"].ToString();
            }

            DateTime date = Convert.ToDateTime(dateStr);

            if (date > DateTime.Now)
                return false;

            return true;
        }

        public static int getEndYear()
        {
            String sql = "SELECT max(TO_DATE(FIX_DATE,'dd/mm/yyyy')) as FIX_DATE FROM FIXTURES";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            DateTime date = Convert.ToDateTime(dt.Rows[0]["FIX_DATE"].ToString());

            return date.Year;
        }

        public static void clear()
        {
            String sql = "DELETE FROM FIXTURES";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Method to determine whether or not an appropriate amount of time (three weeks) has passed between the conclusion of one season and the attempt to start a new one.
        public static bool hasTimeElapsed()
        {
            String sql = "SELECT max(TO_DATE(FIX_DATE,'dd/mm/yyyy')) as FIX_DATE FROM FIXTURES";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();
            
            DateTime date = Convert.ToDateTime(dt.Rows[0]["FIX_DATE"].ToString());

            //learned that subtracting two DateTime objects returns a TimeSpan here https://stackoverflow.com/a/10871765

            TimeSpan daysElapsed = DateTime.Now.Subtract(date);

            if ((int)daysElapsed.TotalDays<21)
            {
                return false;
            }

            return true;
        }

        /*Method for determining the dates that a fixture may be scheduled between. 
         * Returns List containing season start+end dates (first Saturday in August and last Sunday in May of supplied 'startYear').*/
        public static List<DateTime> setDateLimits(int startYear)
        {
            /*****************************************************
            *    Title: How to get the first Sunday of next month for a given date? 
            *    Author: Soner Gönül
            *    Lines: 567-594
            *    Site owner/sponsor: stackoverflow.com
            *    Date: 2015
            *    Code version: edited March 13 2015
            *    Availability: https://stackoverflow.com/a/29026846
            *    Modified: N/A
            *****************************************************/

            DateTime lastDay = new DateTime(startYear + 1, 05, 31);
            DateTime lastSun;
            List<DateTime> dates = new List<DateTime>();

            while (lastDay.DayOfWeek != DayOfWeek.Sunday)
            {
                lastDay = lastDay.AddDays(-1);
            }

            lastSun = lastDay;
            dates.Add(lastSun);

            DateTime firstDay = new DateTime(startYear, 08, 01);
            DateTime firstSat;

            while (firstDay.DayOfWeek != DayOfWeek.Saturday)
            {
                firstDay = firstDay.AddDays(1);
            }

            firstSat = firstDay;

            if (DateTime.Today > firstSat)
                dates.Add(DateTime.Today);
            else
                dates.Add(firstSat);

            return dates;
        }

        //Method to retrieve Team_IDs of teams involved in a particular fixture.
        public static List<int> getIdsFromFixture(int id)
        {
            String sql = "SELECT HOME_TEAM_ID, AWAY_TEAM_ID FROM FIXTURES WHERE FIX_ID=:id";
            List<int> ids = new List<int>();

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":id", id);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                ids.Add(Convert.ToInt32(row["HOME_TEAM_ID"].ToString()));
                ids.Add(Convert.ToInt32(row["AWAY_TEAM_ID"].ToString()));
            }

            return ids;
        }

        //Method to determine if either team playing in the supplied fixture already has a game within 3 days of the supplied date.
        //Method also used in rescheduling, compares Fixture IDs so that a fixture may be moved by < 4 days so long as it does not cause congestion with a different fixture.
        public static bool isCongestion(int id, DateTime date)
        {
            List<int> ids = getIdsFromFixture(id);

            String sql = "SELECT FIX_ID, FIX_DATE FROM FIXTURES WHERE (HOME_TEAM_ID=:htid OR AWAY_TEAM_ID=:atid OR HOME_TEAM_ID=:atid OR AWAY_TEAM_ID=:htid) AND FIX_DATE IS NOT NULL";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":htid", ids[0]);
            cmd.Parameters.Add(":atid", ids[1]);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            TimeSpan timeSpan;

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToDateTime(row["FIX_DATE"]) > date && Convert.ToInt32(row["FIX_ID"]) != id)
                {
                    timeSpan = Convert.ToDateTime(row["FIX_DATE"]).Subtract(date);

                    if ((int)timeSpan.TotalDays < 3)
                        return true;
                }
                else if (Convert.ToDateTime(row["FIX_DATE"]) < date && Convert.ToInt32(row["FIX_ID"]) != id)
                {
                    timeSpan = date.Subtract(Convert.ToDateTime(row["FIX_DATE"]));

                    if ((int)timeSpan.TotalDays < 3)
                        return true;
                }
            }

            return false;
        }

        public static void loadGameweeks(ComboBox cbo)
        {
            String sql = "SELECT DISTINCT GAMEWEEK FROM FIXTURES ORDER BY GAMEWEEK ASC";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbo.Items.Add(Convert.ToInt32(dt.Rows[i]["GAMEWEEK"]));
            }
        }
    }
}
