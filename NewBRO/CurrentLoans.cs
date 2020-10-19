using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace NewBRO
{
    public partial class CurrentLoans : Form

    {
        public DateTime today = DateTime.Today;//sets the variable today to today's date


        private void Overdue(OleDbCommand Cmd, OleDbConnection Conn)//procedure for searching for overdue loans
        {
            //selects all information from loans if the loan is overdue
            Cmd.CommandText = " SELECT * FROM Loans WHERE Complete = 'No - On Loan' AND #" + today.AddDays(-51) + "# >= LoanDue";
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //fills the datagridview if loans have been found
                reader.Close();
                OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dgvLoans.DataSource = table;
                Conn.Close();
                dgvLoans.Show();
                lbComplete.Show();
                cbComplete.Show();
            }
            else
            {
                MessageBox.Show("No records found");//tells the user if there are no overdue loans
            }
        }
        private void Borrower(OleDbCommand Cmd, OleDbConnection Conn)//procedure for searching for all current loans for a particluar borrower
        {
            Cmd.CommandText = " SELECT * FROM Loans WHERE BorrowerNumber = '" + tbBorrowerID.Text + "' AND Complete = 'No - On Loan'";
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
            DataTable table = new DataTable();
            //fills the datagridview with all of the appropriate loans
            da.Fill(table);
            dgvLoans.DataSource = table;
            Conn.Close();
            dgvLoans.Show();
            lbComplete.Show();
            cbComplete.Show();

        }
        private void All(OleDbCommand Cmd, OleDbConnection Conn)//procedure for searching for all current loans
        {
            Cmd.CommandText = " SELECT * FROM Loans WHERE Complete = 'No - On Loan'";
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
            DataTable table = new DataTable();
            //fills the datagridview with all current loans
            da.Fill(table);
            dgvLoans.DataSource = table;
            Conn.Close();
            dgvLoans.Show();
            lbComplete.Show();
            cbComplete.Show();
        }
        private void UpdateLoan(OleDbCommand Cmd, OleDbConnection Conn)
        {
            //must highlight whole row otherwise an error occurs
            Cmd.CommandText = "UPDATE Loans ";
            Cmd.CommandText += "SET Complete = '" + cbComplete.Text + "' WHERE LoanCode = '" + dgvLoans.SelectedRows[0].Cells[0].Value.ToString() + "'";
            Cmd.ExecuteNonQuery();//Updates the 'Complete' status of a particular loan
            Conn.Close();
        }

        public CurrentLoans()
        {
            InitializeComponent();
        }

        private void CurrentLoans_Load(object sender, EventArgs e)
        {
            //only dislpays gbxSelect (group box with radio buttons) until a radio button has been selected
            dgvLoans.Hide();
            gbxBorrowerID.Hide();
            lbComplete.Hide();
            cbComplete.Hide();
            
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Borrower(Cmd, Conn);//exectues the Borrower procedure
            
        }

        private void rbAll_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            All(Cmd, Conn);//executes the all procedure
           
        }

        private void rbBorrower_Click(object sender, EventArgs e)
        {
            gbxBorrowerID.Show();//shows gbxBorrowerID if the Borrower radio button is clicked
        }

        private void rbOverdue_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Overdue(Cmd, Conn);//executes the Overdue procedure
        }

        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoans.SelectedRows.Count > 0)
            {
                cbComplete.Text = dgvLoans.SelectedRows[0].Cells[6].Value.ToString();//sets cbComplete.Text to the value of the complete attribute of the loan selected by the user
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            UpdateLoan(Cmd, Conn);//updates the loan to include the change made to Complete by the user
            //updates the datagridview to include the changes made to the database
            if (rbAll.Checked == true)
            {
                All(Cmd, Conn);
            }
            if (rbBorrower.Checked == true)
            {
                Borrower(Cmd, Conn);
            }
            if(rbOverdue.Checked == true)
            {
                Overdue(Cmd, Conn);
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();//closes the form
        }
    }
}
