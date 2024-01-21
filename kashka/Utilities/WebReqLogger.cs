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
                        string createTableScript = @"CREATE TABLE dbo.UD_WebReqInfo (
                                                      Id INT IDENTITY
                                                     ,InvoiceNumber VARCHAR(61) NOT NULL
                                                     ,StockRoomId INT NOT NULL
                                                     ,FiscalPeriodId INT NOT NULL
                                                     ,UserId INT NOT NULL
                                                     ,Status INT NOT NULL
                                                     ,Message VARCHAR(MAX) NULL
                                                     ,CONSTRAINT PK_UD_WebReqInfo_Id PRIMARY KEY CLUSTERED (Id)
                                                    )";

                        using (SqlCommand createCmd = new SqlCommand(createTableScript, connection))
                        {
                            createCmd.ExecuteNonQuery();
                        }
                    }
                }

                // Insert data into the table
                string insertScript = @"
           INSERT INTO UD_WebReqInfo (InvoiceNumber, StockRoomId, FiscalPeriodId, UserId,Status, Message)
           VALUES (@InvoiceNumber, @StockRoomId, @FiscalPeriodId, @UserId , @Status , @Message)";

                using (SqlCommand insertCmd = new SqlCommand(insertScript, connection))
                {
                    insertCmd.Parameters.AddWithValue("@InvoiceNumber", webReqInfo.InvoiceNumber);
                    insertCmd.Parameters.AddWithValue("@StockRoomId", webReqInfo.StockRoomId);
                    insertCmd.Parameters.AddWithValue("@FiscalPeriodId", webReqInfo.FiscalPeriodId);
                    insertCmd.Parameters.AddWithValue("@UserId", webReqInfo.UserId);
                    insertCmd.Parameters.AddWithValue("@Status", webReqInfo.Status);
                    insertCmd.Parameters.AddWithValue("@Message", webReqInfo.Message);

                    insertCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
