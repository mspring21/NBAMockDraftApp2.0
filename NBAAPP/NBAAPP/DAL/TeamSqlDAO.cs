using NBAAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NBAAPP.DAL
{
    public class TeamSqlDAO : ITeamDAO
    {
        private readonly string connectionString;

        public TeamSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // This gets the draft order/all teams in the draft
        public List<Team> GetDraftOrder()
        {
            List<Team> list = new List<Team>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = "select * from Teams";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Team team = new Team();
                        team.TeamName = Convert.ToString(reader["teamname"]);
                        team.TeamNeeds = Convert.ToString(reader["teamneeds"]);
                        team.TeamPicture = Convert.ToString(reader["TeamPicture"]);
                        list.Add(team);
                    }


                }
            }
            catch (SqlException ex)
            {
                // TODO: Log error here
                throw ex;
            }
            return list;
        }


        // This gets a single team depending on ID
        public Team GetSingleTeamWithId(int id)
        {
            Team team = new Team();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = "select * from Teams where Id = @id";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        team.TeamName = Convert.ToString(reader["teamname"]);
                        team.TeamNeeds = Convert.ToString(reader["teamneeds"]);
                        team.TeamPicture = Convert.ToString(reader["TeamPicture"]);
                    }


                }
            }
            catch (SqlException ex)
            {
                // TODO: Log error here
                throw ex;
            }
            return team;
        }
    }
}
