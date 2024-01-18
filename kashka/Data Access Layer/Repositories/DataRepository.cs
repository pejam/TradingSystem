using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Microsoft.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using kashka.Business_Logic_Layer.Models;

namespace kashka.Data_Access_Layer.Repositories
{
    public class DataRepository
    {
        private readonly string connectionString;

        public DataRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM Person", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            connection.Close();
                            return dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public List<Person> GetAllPerson()
        {
            List<Person> people = new List<Person>();

            string query = "SELECT * FROM Person";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Person person = new Person
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            };

                            people.Add(person);
                        }
                    }
                }
            }

            return people;
        }

        public void SaveData(string data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO YourTable (ColumnName) VALUES (@Data)", connection))
                {
                    command.Parameters.AddWithValue("@Data", data);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
