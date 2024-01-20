using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kashka.Business_Logic_Layer.Models;

namespace kashka.Utilities
{
    public class WebReqLogger
    {
        public static void InsertData(WebReqInfo webReqInfo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the table exists
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'UD_WebReqInfo'", connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        // Table doesn't exist, create it
                        string createTableScript = @"
                  CREATE TABLE UD_WebReqInfo (
                      SPId NVARCHAR(MAX),
                      SPAId NVARCHAR(MAX),
                      Status NVARCHAR(MAX),
                      Message NVARCHAR(MAX)
                  )";

                        using (SqlCommand createCmd = new SqlCommand(createTableScript, connection))
                        {
                            createCmd.ExecuteNonQuery();
                        }
                    }
                }

                // Insert data into the table
                string insertScript = @"
           INSERT INTO UD_WebReqInfo (SPId, SPAId, Status, Message)
           VALUES (@SPId, @SPAId, @Status, @Message)";

                using (SqlCommand insertCmd = new SqlCommand(insertScript, connection))
                {
                    insertCmd.Parameters.AddWithValue("@SPId", webReqInfo.FactorId);
                    insertCmd.Parameters.AddWithValue("@SPAId", webReqInfo.FactorArticleId);
                    insertCmd.Parameters.AddWithValue("@Status", webReqInfo.Status);
                    insertCmd.Parameters.AddWithValue("@Message", webReqInfo.Message);

                    insertCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
