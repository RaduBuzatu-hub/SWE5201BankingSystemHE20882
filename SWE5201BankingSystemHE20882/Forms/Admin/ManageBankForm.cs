using System;                       // gives us basic system things like string, int, etc.
using System.Data;                  // helps us work with tables and data rows
using System.Windows.Forms;         // lets us make buttons, forms, and boxes
using SWE5201BankingSystemHE20882.Services; // this is where our BankService class is

namespace SWE5201BankingSystemHE20882
{
    // this form is used by admin to add, view or delete banks and their branches
    public partial class ManageBankForm : Form
    {
        // we use BankService to talk to the database (no connection string here)
        private readonly BankService _bankService = new BankService();

        // when form is made, this runs first
        public ManageBankForm()
        {
            InitializeComponent(); // builds the form controls
        }

        // when the form finishes loading, this event runs
        private void ManageBankForm_Load(object sender, EventArgs e)
        {
            LoadBanks(); // this will load and show all banks in the table
        }

        // this method fetches banks and branches and shows in the grid
        private void LoadBanks()
        {
            dgvBanks.DataSource = _bankService.GetAllBranchesWithBanks(); // get bank info from service
        }

        // this happens when admin clicks the "Add Bank" button
        private void btnAddBank_Click(object sender, EventArgs e)
        {
            string bankName = txtBankName.Text.Trim();       // get what admin typed for bank
            string bankBranch = txtBankBranch.Text.Trim();   // get the branch they typed

            // make sure bank name is not empty
            if (string.IsNullOrWhiteSpace(bankName))
            {
                MessageBox.Show("Please enter a Bank Name."); // tell user to enter name
                return;
            }

            // call the service to add the bank and branch
            string result = _bankService.AddBankAndBranch(bankName, bankBranch);
            MessageBox.Show(result); // show success or error

            LoadBanks();         // refresh the bank list in the grid
            txtBankName.Clear(); // clear the textbox
            txtBankBranch.Clear();
        }

        // this deletes a whole bank and its branches when clicked
        private void btnDeleteBank_Click(object sender, EventArgs e)
        {
            // if nothing selected, show message
            if (dgvBanks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bank to delete.");
                return;
            }

            // get the bank id from selected row
            int bankId = Convert.ToInt32(dgvBanks.SelectedRows[0].Cells["BankID"].Value);

            // ask user to confirm deletion
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this bank and its branches?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return; // if user says no, stop

            // delete the bank and show result
            string result = _bankService.DeleteBankWithBranches(bankId);
            MessageBox.Show(result);

            LoadBanks(); // refresh list
        }

        // this deletes just one branch (not whole bank)
        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            // check if row is picked
            if (dgvBanks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a branch to delete.");
                return;
            }

            // get the branch id from the row
            int branchId = Convert.ToInt32(dgvBanks.SelectedRows[0].Cells["BranchID"].Value);

            // ask user to confirm
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this branch?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return; // if not yes, do nothing

            // delete the branch and show what happened
            string result = _bankService.DeleteBranch(branchId);
            MessageBox.Show(result);
            LoadBanks(); // update the list
        }

        // if user clicks cancel, we just close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // close this window
        }
    }
}
