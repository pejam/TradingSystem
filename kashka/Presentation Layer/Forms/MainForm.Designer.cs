using kashka.Data_Access_Layer.Repositories;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
using Microsoft.Data.SqlClient;
using kashka.Business_Logic_Layer.Models;

namespace kashka.Presentation_Layer.Forms
{
    partial class MainForm : Form
    {

        private readonly DataRepository dataRepository;

        public MainForm()
        {
            InitializeComponent();

            // Initialize the repository with your connection string
            dataRepository = new DataRepository(
                ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
            LoadData();
        }

        private void LoadData()
        {
            // Load data from the database and bind it to the DataGridView
            dataGridView.ReadOnly = true;
            //dataGridView.DataSource = dataRepository.GetData();
            List<Person> people = dataRepository.GetAllPerson();
            dataGridView.DataSource = people;
        }

        /*private void btnSave_Click(object sender, EventArgs e)
        {
            // Save data to the database and refresh the DataGridView
            dataRepository.SaveData(txtData.Text);
            dataGridView.DataSource = dataRepository.GetData();
        }*/

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            ConnectionButton = new Button();
            txtNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(35, 77);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 31;
            dataGridView.Size = new Size(601, 279);
            dataGridView.TabIndex = 0;
            // 
            // ConnectionButton
            // 
            ConnectionButton.Location = new Point(357, 473);
            ConnectionButton.Name = "ConnectionButton";
            ConnectionButton.Size = new Size(279, 34);
            ConnectionButton.TabIndex = 1;
            ConnectionButton.Text = "Connection Status";
            ConnectionButton.UseVisualStyleBackColor = true;
            ConnectionButton.Click += ConnectionButton_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(100, 100);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(150, 29);
            txtNumber.TabIndex = 0;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 767);
            Controls.Add(ConnectionButton);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        private TextBox txtNumber;
        private DataGridView dataGridView;
        private Button ConnectionButton;
    }
}