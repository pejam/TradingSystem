using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kashka.Presentation_Layer.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int userId = IsValidUser(username, password);
            if (userId != 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.userId = userId;
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show(".کاربر یافت نشد. لطفا مجددا تلاش کنید", "ورود ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int IsValidUser(string username, string password)
        {
            // Retrieve the connection string from the app.config
            string connectionString = ConfigurationManager
                .ConnectionStrings["SysConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int count = 0;
                    ICodepageConvertor _codepageService = new CodepageConvertor();
                    var usernameConverted = _codepageService.toTadbir(username);

                    string query = $"SELECT ugId FROM __Enroll__ WHERE ugName = @ugName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ugName", usernameConverted);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            count = Convert.ToInt32(result);
                        }
                    }
                    return count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }


    }

    public class User
    {
        public int ugId { get; set; }
        public string ugName { get; set; }
    }
}
