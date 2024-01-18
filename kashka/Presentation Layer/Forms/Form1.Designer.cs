

using Microsoft.Data.SqlClient;
using System.Configuration;

namespace kashka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(551, 558);
            button1.Name = "button1";
            button1.Size = new Size(457, 30);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new Size(996, 436);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 615);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();

            InitForm();

            ResumeLayout(false);



        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;


        private void InitForm()
        {

            //string localConnectionString = "Server=130.185.75.230,49878;Database=DEMO;User ID=TadbirUser;Password=$$$%%%;Trusted_Connection=False";
            //string connectionString = ConfigurationManager.ConnectionStrings[localConnectionString].ConnectionString;
            using (SqlConnection connection = new SqlConnection(Constants.CONN_STRING))
            {
                // Open the connection
                connection.Open();

                // Create a SqlCommand object with your SQL query
                string query = "SELECT * FROM Person";
                SqlCommand command = new SqlCommand(query, connection);

                // Execute the query and retrieve the data
                SqlDataReader reader = command.ExecuteReader();

                // Bind the data to the DataGridView control
                dataGridView1.DataSource = reader;
            }
        }
    }
}