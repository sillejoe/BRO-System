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
    
    public partial class BorrowersExisting : Form
    {
        InputValidation IV = new InputValidation();
        string BorrowerNumber; bool temp, temp2; int count = 0;
        public void LengthCheck2(string textbox, int length, bool temp, ref int count)
        {
            temp = IV.LengthCheck2(textbox, length);
            if (temp == true)
            {
                count++;
            }
        }
        public void LengthCheck1(string textbox, int length, bool temp, ref int count)
        {
            temp = IV.LengthCheck1(textbox, length);
            if (temp == true)
            {
                count++;
            }
        }

        public BorrowersExisting()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BorrowersExisting_Load(object sender, EventArgs e)
        {
            gbxBorrowerData.Hide();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT * FROM Borrowers WHERE BorrowerNumber = '" + tbBorrowerID.Text + "'"; //selects everything from borrowers
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)//If the borrower number is found the following code will be executed
            {
                gbxBorrowerData.Show();
                reader.Read();
                BorrowerNumber = Convert.ToString(reader["BorrowerNumber"]);
                //The text boxes are all filled with the information found for the enetered BorrowerNumber found in the database
                tbFName.Text = Convert.ToString(reader["Firstname"]);
                tbSurname.Text = Convert.ToString(reader["Surname"]);
                tbDOB.Text = Convert.ToString(reader["DateOfBirth"]);
                tbSex.Text = Convert.ToString(reader["Sex"]);
                tbAddress.Text = Convert.ToString(reader["Address"]);
                tbEmail.Text = Convert.ToString(reader["EmailAddress"]);
                tbNumber.Text = Convert.ToString(reader["ContactNumber"]);
                cbBranch.Text = Convert.ToString(reader["Branch"]);
                cbCategory.Text = Convert.ToString(reader["BorrowerCategory"]);
                Conn.Close();
            }
            else
            {
                MessageBox.Show("BorrowerNumber not found");//tells user the BorrowerNumber has not been found
                gbxBorrowerData.Hide();

            }
        }

        private void btUpdate_Click(object sender, EventArgs e)//Used to update an existing record
        {
            //validation for the textboxes being updated
            temp = IV.DateValid(tbDOB.Text);
            if (temp == false)
            {
                MessageBox.Show("Please enter Date Of Birth in format dd/mm/yyyy");
            }
            else
            {
                count++;
            }
            foreach (var c in gbxBorrowerData.Controls)
            {
                if (c is TextBox)
                {
                    temp = IV.Null(((TextBox)c).Text);
                    if (temp == false)
                    {
                        count++;
                    }



                }
                if (c is ComboBox)
                {
                    temp = IV.Null(((ComboBox)c).Text);
                    if (temp == false)
                    {
                        count++;
                    }

                }

            }
            temp = IV.CharCheck(tbEmail.Text, Convert.ToString('@'));
            if (temp == true)
            {
                count++;
            }
            else
            {
                MessageBox.Show("Please enter a valid email address");
            }
            temp = IV.CharCheck2(tbNumber.Text, "07");
            temp2 = IV.CharCheck2(tbNumber.Text, "0161");
            if (temp == false && temp2 == false)
            {
                MessageBox.Show("Please enter a valid contact number");
            }
            else
            {
                count++;
            }

            LengthCheck2(tbFName.Text, 25, temp, ref count);
            LengthCheck2(tbSurname.Text, 20, temp, ref count);
            LengthCheck2(tbSex.Text, 6, temp, ref count);
            LengthCheck1(tbNumber.Text, 11, temp, ref count);
            LengthCheck2(tbAddress.Text, 40, temp, ref count);
            LengthCheck2(tbEmail.Text, 25, temp, ref count);

            if (count == 18)//count = 18 when everything is valid
            {
                OleDbConnection Conn = new OleDbConnection(Program.ConnString);
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                //updates the databse to include what the user has changed
                Cmd.CommandText = "UPDATE Borrowers";
                Cmd.CommandText += " SET Firstname = '" + tbFName.Text + "', Surname =  '" + tbSurname.Text + "', ";
                Cmd.CommandText += " DateOfBirth = '" + tbDOB.Text + "', Sex =  '" + tbSex.Text + "', ";
                Cmd.CommandText += " Address = '" + tbAddress.Text + "', EmailAddress =  '" + tbEmail.Text + "', ";
                Cmd.CommandText += " ContactNumber = '" + tbNumber.Text + "', BorrowerCategory =  '" + cbCategory.Text + "', Branch = '" + cbBranch.Text + "'";
                Cmd.CommandText += " WHERE BorrowerNumber = '" + BorrowerNumber + "'";
                Cmd.ExecuteNonQuery();
                Conn.Close();
                count = 0;//resets count
            }
            else
            {
                //MessageBox.Show(count.ToString());
                MessageBox.Show("Please make sure that there are no empty fields and everything entered is valid. ");//tells the user to check the inputs
                count = 0;//resets count
            }
        }

        private void btDelete_Click(object sender, EventArgs e)//deletes all records involving this borrower from the database
        {
            DialogResult Confirmation = MessageBox.Show("Are you sure you wish to delete this student?", "Confirmation", MessageBoxButtons.YesNo);//confirms with the user that they want to delete the borrower
            if (Confirmation == DialogResult.Yes)
            {
                OleDbConnection Conn = new OleDbConnection(Program.ConnString);
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                //deletes all loans that the borrower has ever made
                Cmd.CommandText = "DELETE FROM Loans ";
                Cmd.CommandText += "WHERE BorrowerNumber = '" + BorrowerNumber + "'";
                Cmd.ExecuteNonQuery();

                MessageBox.Show(Cmd.CommandText);
                //deletes the borrower and all of their details
                Cmd.CommandText = "DELETE FROM Borrowers ";
                Cmd.CommandText += "WHERE BorrowerNumber = '" + BorrowerNumber + "'";
                Cmd.ExecuteNonQuery();
                Conn.Close();
              
                MessageBox.Show("Deleted");
             
                //clears all text boxes and combo boxes
                foreach (var c in gbxBorrowerData.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                        
                
                    }
                    if( c is ComboBox)
                    {
                        ((ComboBox)c).Text = String.Empty;

                    }
                }
                tbBorrowerID.Clear();

            }
      
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();//closes the form
        }
    }
}
