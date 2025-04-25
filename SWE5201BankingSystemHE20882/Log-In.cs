using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SWE5201BankingSystemHE20882
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected Index Changed");
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnBankStaffLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();  // use actual name from designer
            string password = txtPassword.Text.Trim();  // match this too

            string connectionString = "Server=localhost;Database=BankingDB;Trusted_Connection=True;";
            string query = "SELECT COUNT(*) FROM BankStaff WHERE Username = @username AND Password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Login successful!", "Success");
                    // Open the MainForm dashboard
                    MainForm dashboard = new MainForm();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials.", "Login Failed");
                }
            }
        }
    }
}
