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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Log_In loginForm = new Log_In();
            loginForm.Show();
            this.Close();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=BankingDB;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewCustomers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customers: " + ex.Message);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog(); // or use .Show() if you don't want it modal
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                int selectedCustomerId = Convert.ToInt32(dataGridViewCustomers.SelectedRows[0].Cells["CustomerID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost;Database=BankingDB;Trusted_Connection=True;";
                    string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Customer deleted successfully!");
                            btnViewCustomers.PerformClick(); // Refresh the table
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }

        }
    }
}
