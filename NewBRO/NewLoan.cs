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
using SampleLibrary;

namespace NewBRO
{
    public partial class NewLoan : Form
    {
       

        public string NL()//function to generate a new LoanCode
        {
            string LastID = "", NewCode, FirstHalf, SecondHalf;
            int SecondHalfI, NoOfZeros;
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT Top 1 * FROM Loans ORDER BY LoanCode DESC"; //selects everything from borrowers
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)//If a record is found display details
            {
                reader.Read();
                LastID = Convert.ToString(reader["LoanCode"]); //gets the borrowernumber from borrowers
                FirstHalf = LastID.Substring(0, 2);
                SecondHalf = LastID.Substring(2, 12);
                SecondHalfI = Convert.ToInt32(SecondHalf) + 1; //incrementing the borrowernumber by 1 each time a new borrower is added
                SecondHalf = SecondHalfI.ToString();
                NoOfZeros = 13 - SecondHalf.Length;
                SecondHalf = SecondHalf.PadLeft(NoOfZeros, '0');
                NewCode = FirstHalf + SecondHalf;

            }
            else
            {
                NewCode = "L1000000000001";//if it is the first loan
            }
            reader.Close();
            Conn.Close();
            return NewCode;
            
        }

        private void btAdd_Click(object sender, EventArgs e)//error?
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT Borrowers.BorrowerNumber, Items.ItemBarcode, Items.ItemLocation "; 
            Cmd.CommandText += "FROM Borrowers, Items ";
            Cmd.CommandText += "WHERE "; 
            Cmd.CommandText += "Borrowers.BorrowerNumber = '" + tbBorrowerNumber.Text + "' AND Items.ItemBarcode = '" + tbBarcode.Text + "'";
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)//checks whether the BorrowerNumber and ItemBarcode exist
            {
                //Counts how many items the borrower currently has out on loan
                Conn.Close();
                Conn.Open();
                Cmd.CommandText = "SELECT COUNT(BorrowerNumber) AS BN FROM Loans WHERE BorrowerNumber = '" + tbBorrowerNumber.Text + "' AND Complete = 'No - On Loan'";
                int temp;
                if(Cmd.ExecuteScalar() != DBNull.Value)
                {
                    temp = Convert.ToInt32(Cmd.ExecuteScalar());//stores the number of loans the borrower currently has out

                }
                else
                {
                    temp = 0;//if no loans are found, then temp = 0
                }
                Conn.Close();
                MessageBox.Show(temp.ToString());//shows the number of loans the borrower currently has out

                if ( temp < 10)//if the number of current loans is less than ten, the new loan will be made
                {
                    //Conn.Open();
                   // Cmd.CommandText = "SELECT ItemLocation ";
                   // Cmd.CommandText += "FROM Items ";
                   // Cmd.CommandText += "WHERE ItemBarcode = '" + tbBarcode.Text + "'";
                    //OleDbDataReader reader1 = Cmd.ExecuteReader();
                    //reader1.Read();
                   // MessageBox.Show(reader1["ItemLocation"].ToString());
                    Conn.Close();
                    Conn.Open();
                    Cmd.CommandText = "INSERT INTO Loans ";
                    Cmd.CommandText += "VALUES('" + tbLoanCode.Text + "','" + tbBorrowerNumber.Text + "','" + tbBarcode.Text + "', #" + tbIssued.Text + "#, '" + cbLoanPolicy.Text + "', #" + tbLoanDue.Text + "#, 'No - On Loan')";
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Recorded");

                    //resets the textboxes and produces a new loan code
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;


                        }
                        if (c is ComboBox)
                        {
                            ((ComboBox)c).Text = String.Empty;

                        }
                        tbLoanCode.Text = NL();
                    }
                }
                else //if the number of loans is = 10 than the loan will not be made
                {
                 
                    MessageBox.Show("Borrower already has max number of items out");//tells user the loan cannot be made
                }
             
            }
            else
            {
                MessageBox.Show("Not Found");//tells the user that the BorrowerNumber or the ItmeBarcode has not been found
            }
        }
 
        public NewLoan()
        {
            InitializeComponent();
        }

        private void NewLoan_Load(object sender, EventArgs e)
        {
            //Automatically sets the LoanCode of a new loan
           
            tbLoanCode.Text = NL();
            tbLoanCode.ReadOnly = true; //sets tbLoanCode to read only so it cannot be changed

            //Set the Issued Date and LoanDue Date
            tbIssued.Text = Convert.ToString(DateTime.Today);//sets the tbIssued to today
            tbLoanDue.Text = Convert.ToString(DateTime.Today.AddDays(21));//sets the due date to be 3 weeks from now
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();//closes the form
        }
    }
}
