using NBAAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NBAAPP.DAL
{
    public class ProspectsSqlDAO : IProspectsDAO
    {
        private readonly string connectionString;

        public ProspectsSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Grabs all Prospects from the Database regardless of Draft Status.
        /// </summary>
        /// <returns>List of Prospect objects.</returns>
        public List<Prospect> GetAllProspects()
        {
            List<Prospect> list = new List<Prospect>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = "select * from Prospects";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Prospect p = new Prospect();
                        p.Id = Convert.ToInt32(reader["Id"]);
                        p.Age = Convert.ToInt32(reader["Age"]);
                        p.Assists = Convert.ToDecimal(reader["Assists"]);
                        p.Blocks = Convert.ToDecimal(reader["Blocks"]);
                        p.Height = Convert.ToString(reader["Height"]);
                        p.Points = Convert.ToDecimal(reader["Points"]);
                        p.Position = Convert.ToString(reader["Position"]);
                        p.ProspectName = Convert.ToString(reader["ProspectName"]);
                        p.Rating = Convert.ToInt32(reader["Rating"]);
                        p.Rebounds = Convert.ToDecimal(reader["Rebounds"]);
                        p.School = Convert.ToString(reader["School"]);
                        p.Steals = Convert.ToDecimal(reader["Steals"]);
                        p.Weight = Convert.ToInt32(reader["Weight"]);
                        p.ProfilePhoto = Convert.ToString(reader["ProfilePhoto"]);
                        p.DraftedStatus = Convert.ToInt32(reader["DraftedStatus"]);
                        p.TeamDrafted = Convert.ToString(reader["TeamDrafted"]);
                        list.Add(p);
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

        /// <summary>
        /// This grabs all Prospects in Database that is available to be drafted.
        /// </summary>
        /// <returns>List of Prospect objects.</returns>
        public List<Prospect> GetAllProspectsAvailableForDraft(int status)
        {
            List<Prospect> list = new List<Prospect>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = "select * from Prospects where DraftedStatus = @status";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@status", status);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Prospect p = new Prospect();
                        p.Id = Convert.ToInt32(reader["Id"]);
                        p.Age = Convert.ToInt32(reader["Age"]);
                        p.Assists = Convert.ToDecimal(reader["Assists"]);
                        p.Blocks = Convert.ToDecimal(reader["Blocks"]);
                        p.Height = Convert.ToString(reader["Height"]);
                        p.Points = Convert.ToDecimal(reader["Points"]);
                        p.Position = Convert.ToString(reader["Position"]);
                        p.ProspectName = Convert.ToString(reader["ProspectName"]);
                        p.Rating = Convert.ToInt32(reader["Rating"]);
                        p.Rebounds = Convert.ToDecimal(reader["Rebounds"]);
                        p.School = Convert.ToString(reader["School"]);
                        p.Steals = Convert.ToDecimal(reader["Steals"]);
                        p.Weight = Convert.ToInt32(reader["Weight"]);
                        p.ProfilePhoto = Convert.ToString(reader["ProfilePhoto"]);
                        p.DraftedStatus = Convert.ToInt32(reader["DraftedStatus"]);
                        p.TeamDrafted = Convert.ToString(reader["TeamDrafted"]);
                        list.Add(p);
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

        /// <summary>
        /// This grabs all the Drafted Prospects in the Database.
        /// </summary>
        /// <param name="status"></param>
        /// <returns>List of Prospect objects.</returns>
        public List<Prospect> GetAllDraftedProspects(int status)
        {
            List<Prospect> list = new List<Prospect>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = "select * from Prospects where DraftedStatus = @status";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@status", status);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Prospect p = new Prospect();
                        p.Id = Convert.ToInt32(reader["Id"]);
                        p.Age = Convert.ToInt32(reader["Age"]);
                        p.Assists = Convert.ToDecimal(reader["Assists"]);
                        p.Blocks = Convert.ToDecimal(reader["Blocks"]);
                        p.Height = Convert.ToString(reader["Height"]);
                        p.Points = Convert.ToDecimal(reader["Points"]);
                        p.Position = Convert.ToString(reader["Position"]);
                        p.ProspectName = Convert.ToString(reader["ProspectName"]);
                        p.Rating = Convert.ToInt32(reader["Rating"]);
                        p.Rebounds = Convert.ToDecimal(reader["Rebounds"]);
                        p.School = Convert.ToString(reader["School"]);
                        p.Steals = Convert.ToDecimal(reader["Steals"]);
                        p.Weight = Convert.ToInt32(reader["Weight"]);
                        p.ProfilePhoto = Convert.ToString(reader["ProfilePhoto"]);
                        p.DraftedStatus = Convert.ToInt32(reader["DraftedStatus"]);
                        p.TeamDrafted = Convert.ToString(reader["TeamDrafted"]);
                        list.Add(p);
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

        /// <summary>
        /// This will grab only the top 5 AVAILABLE Prospects by Rating in the Database.
        /// </summary>
        /// <param name="status"></param>
        /// <returns>List of Prospect objects.</returns>
        public List<Prospect> GetTopFourProspectsAvailableForDraft(int status)
        {
            List<Prospect> list = new List<Prospect>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = "select top(4) * from Prospects where DraftedStatus = @status order by Rating	desc";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@status", status);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Prospect p = new Prospect();
                        p.Id = Convert.ToInt32(reader["Id"]);
                        p.Age = Convert.ToInt32(reader["Age"]);
                        p.Assists = Convert.ToDecimal(reader["Assists"]);
                        p.Blocks = Convert.ToDecimal(reader["Blocks"]);
                        p.Height = Convert.ToString(reader["Height"]);
                        p.Points = Convert.ToDecimal(reader["Points"]);
                        p.Position = Convert.ToString(reader["Position"]);
                        p.ProspectName = Convert.ToString(reader["ProspectName"]);
                        p.Rating = Convert.ToInt32(reader["Rating"]);
                        p.Rebounds = Convert.ToDecimal(reader["Rebounds"]);
                        p.School = Convert.ToString(reader["School"]);
                        p.Steals = Convert.ToDecimal(reader["Steals"]);
                        p.Weight = Convert.ToInt32(reader["Weight"]);
                        p.ProfilePhoto = Convert.ToString(reader["ProfilePhoto"]);
                        p.DraftedStatus = Convert.ToInt32(reader["DraftedStatus"]);
                        p.TeamDrafted = Convert.ToString(reader["TeamDrafted"]);
                        list.Add(p);
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


        /// <summary>
        /// This will update the drafted status of the player drafted.
        /// </summary>
        /// <param name="status"></param>
        /// <returns>Void</returns>
        public void UpdateStatusOfDraftedPlayer(int id, string teamDrafted)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = "Update Prospects Set DraftedStatus = 2, TeamDrafted = @teamDrafted where Id = @id";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@teamDrafted", teamDrafted);
                    cmd.ExecuteScalar();
                   
                }
            }
            catch (SqlException ex)
            {
                // TODO: Log error here
                throw ex;
            }
            return;
        }


        /// <summary>
        /// This will grab only the top 5 AVAILABLE Prospects by Rating in the Database.
        /// </summary>
        /// <param name="status"></param>
        /// <returns>List of Prospect objects.</returns>
        public Prospect GetProspectById(int id)
        {
            Prospect prospect = new Prospect();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = "select * from Prospects where Id = @id";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Prospect p = new Prospect();
                        p.Id = Convert.ToInt32(reader["Id"]);
                        p.Age = Convert.ToInt32(reader["Age"]);
                        p.Assists = Convert.ToDecimal(reader["Assists"]);
                        p.Blocks = Convert.ToDecimal(reader["Blocks"]);
                        p.Height = Convert.ToString(reader["Height"]);
                        p.Points = Convert.ToDecimal(reader["Points"]);
                        p.Position = Convert.ToString(reader["Position"]);
                        p.ProspectName = Convert.ToString(reader["ProspectName"]);
                        p.Rating = Convert.ToInt32(reader["Rating"]);
                        p.Rebounds = Convert.ToDecimal(reader["Rebounds"]);
                        p.School = Convert.ToString(reader["School"]);
                        p.Steals = Convert.ToDecimal(reader["Steals"]);
                        p.Weight = Convert.ToInt32(reader["Weight"]);
                        p.ProfilePhoto = Convert.ToString(reader["ProfilePhoto"]);
                        p.DraftedStatus = Convert.ToInt32(reader["DraftedStatus"]);
                        p.TeamDrafted = Convert.ToString(reader["TeamDrafted"]);
                        prospect = p;
                    }


                }
            }
            catch (SqlException ex)
            {
                // TODO: Log error here
                throw ex;
            }
            return prospect;
        }


    }
}
