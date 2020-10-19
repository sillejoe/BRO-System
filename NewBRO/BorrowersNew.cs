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
using SampleLibrary; //links to SampleLibrary

namespace NewBRO
{
    public partial class BorrowersNew : Form
    {
        string LastID = "", NewID, FirstHalf, SecondHalf; bool temp, temp2; int SecondHalfI, NoOfZeros, count = 0;
        InputValidation IV = new InputValidation(); //declaring an instance of InputValidation from SampleLibrary
       
        public void ID()//procedure to create a new BorrowerNumber
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT Top 1 * FROM Borrowers ORDER BY BorrowerNumber DESC"; //selects everything from borrowers
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)//If a record is found display details
            {
                reader.Read();
                LastID = Convert.ToString(reader["BorrowerNumber"]); //gets the borrowernumber from borrowers
                FirstHalf = LastID.Substring(0, 2);
                SecondHalf = LastID.Substring(2, 12);
                SecondHalfI = Convert.ToInt32(SecondHalf) + 1; //incrementing the borrowernumber by 1 each time a new borrower is added
                SecondHalf = SecondHalfI.ToString();
                NoOfZeros = 13 - SecondHalf.Length;
                SecondHalf = SecondHalf.PadLeft(NoOfZeros, '0');
                NewID = FirstHalf + SecondHalf;

            }
            else
            {
                NewID = "D1000000000001";//first BorrowerNumber if database has just been created
            }
            reader.Close();
            Conn.Close();
            tbBorrowerNumber.Text = NewID;//displays the new BorrowerNumber in tbBorrowerNumber
        }
        public void LengthCheck2(string textbox, int length, bool temp, ref int count)//procedure for checking the length of an attribute that doesn't have to be a certtain length
        {
            temp = IV.LengthCheck2(textbox, length);//uses the routine found in SampleLibrary
            if (temp == true)
            {
                count++;//if the attribute is the correct length, count is incremented
            }
        }
        public void LengthCheck1(string textbox, int length, bool temp, ref int count)//procedure for checking the length of an attribute that has to be a certain length
        {
            temp = IV.LengthCheck1(textbox, length);//uses the routine found in SampleLibrary
            if (temp == true)
            {
                count++;//if the attribute is the correct length, count is incremented
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public BorrowersNew()
        {
            InitializeComponent();
            
        }
        

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void BorrowersNew_Load(object sender, EventArgs e)
        {
            ID();//uses the routine ID to generate a new BorrowerNumber
            tbBorrowerNumber.ReadOnly = true;//sets tbBorrowerNumber to read only so it can't be editted by the user
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //Validation for all tbs
           
            
            temp = IV.DateValid(tbDOB.Text);//uses the routine found in SampleLibrary to check whether the date of birth entered by the user is valid
            if (temp == false)
            {
                MessageBox.Show("Please enter Date Of Birth in format dd/mm/yyyy");//message telling user the date is invalid and why
            }
            else
            {
                count++;//count is incremented if the date is valid
            }
            foreach (var c in this.Controls)//checks to see whether something has been entered in each textbox
            {
                if (c is TextBox)
                {
                    temp = IV.Null(((TextBox)c).Text);
                    if( temp == false)
                    {
                        count++;//count is incremented if the textbox has something in it
                    }
                   


                }
                if (c is ComboBox)//checks to see whether something has been selected for each combobox
                {
                    temp = IV.Null(((ComboBox)c).Text);
                    if (temp == false)
                    {
                        count++;//count is incremented if the something has been selected for the combobox
                    }
                    
                }
                
            }
            temp = IV.CharCheck(tbEmail.Text, Convert.ToString('@'));//checks to see whether the email entered is valid using the routine found in SampleLibrary
            if (temp == true)
            {
                count++;//count is incremented if email is valid
            }
            else
            {
                MessageBox.Show("Please enter a valid email address");//notifies user if email is invalid
            }
            //checks to see whether the contact number is valid
            temp = IV.CharCheck2(tbNumber.Text, "07");
            temp2 = IV.CharCheck2(tbNumber.Text, "0161");
            if (temp == false && temp2 == false)//if the number doesn't start with '07' or '0161' then it is invalid
            {
                MessageBox.Show("Please enter a valid contact number");//tells  user number is invalid
            }
            else
            {
                count++;// count is incremented if valid
            }
            //checks whether everything entered is the correct length barring what is in the combo boxes as all the options they can choose from are correct
            //count is incremented each time the lenght of an input is correct
            LengthCheck2(tbFName.Text, 25, temp, ref count);
            LengthCheck2(tbSurname.Text, 20, temp, ref count);
            LengthCheck2(tbSex.Text, 6, temp, ref count);
            LengthCheck1(tbNumber.Text, 11, temp, ref count);
            LengthCheck2(tbAddress.Text, 40, temp, ref count);
            LengthCheck2(tbEmail.Text, 25, temp, ref count);



            if (count == 19)//count = 19 if all inputs are valid
            {
                //MessageBox.Show(count.ToString());
                OleDbConnection Conn = new OleDbConnection(Program.ConnString);
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                //adds the new borrower to the database
                string SQL = "INSERT INTO Borrowers ";
                SQL += " VALUES('" + Convert.ToString(tbBorrowerNumber.Text) + "', '" + tbFName.Text + "',' " + tbSurname.Text + "', #" + tbDOB.Text + "#, '" + tbSex.Text + "', '" + tbAddress.Text + "', '" + tbEmail.Text + "','" + Convert.ToString(tbNumber.Text) + "','";
                SQL += cbCategory.SelectedItem + "', '" + cbBranch.SelectedItem + "')";
                Cmd.CommandText = SQL;
                Cmd.ExecuteNonQuery();
                Conn.Close();
                count = 0;//resets count
                foreach (var c in this.Controls)//clears all text boxes and combo boxes
                {
                    if (c is TextBox && c != tbBorrowerNumber)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                    if (c is ComboBox)
                    {
                        ((ComboBox)c).Text = String.Empty;

                    }
                }

                ID();//generates a new BorrowerNumber after all text boxes have been cleared
            }




            else//if there are any invalid inputs
            {
                //MessageBox.Show(count.ToString());

                MessageBox.Show("Please make sure that there are no empty fields and everything entered is valid. ");//displays an error message
                count = 0;//restes count
            }
         




        }
    }
}
