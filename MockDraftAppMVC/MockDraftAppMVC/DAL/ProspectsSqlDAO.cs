using MockDraftAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MockDraftAppMVC.DAL
{
    public class ProspectsSqlDAO : IProspectsDAO
    {
        private readonly string connectionString;

        public ProspectsSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<Prospect> GetProspect()
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



    }
}
