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
    public partial class Form1 : Form
    {
        public static string Username, Password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (File.Exists("DatabaseCS.accdb") == false)//If the database doesn't exist
            {
                ADOX.Catalog cat = new ADOX.Catalog();
                cat.Create(Program.ConnString); //Use constant defined in Program.cs to create database
                OleDbConnection Conn = new OleDbConnection(Program.ConnString);
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                //Create Classes Users - The CREATE command needs to be constructed as one string.
                Cmd.CommandText = "CREATE TABLE Users(Username VARCHAR(10),";
                Cmd.CommandText += " PWord VARCHAR(15), PRIMARY KEY (Username))";
                Cmd.ExecuteNonQuery(); //Used because no result is returned
                Cmd.CommandText = "INSERT INTO Users VALUES('Adm1n','Pas$w0rd')";
                Cmd.ExecuteNonQuery();
                //Create the Borrowers table
                Cmd.CommandText = "CREATE TABLE Borrowers(BorrowerNumber CHAR(14),";
                Cmd.CommandText += " Firstname VARCHAR(25), Surname VARCHAR(20),";
                Cmd.CommandText += " DateOfBirth DATE, Sex VARCHAR(6),";
                Cmd.CommandText += " Address VARCHAR(40), EmailAddress VARCHAR(25), ContactNumber CHAR(11),";
                Cmd.CommandText += " BorrowerCategory VARCHAR(20), Branch VARCHAR(15),";
                Cmd.CommandText += " PRIMARY KEY (BorrowerNumber))";
                Cmd.ExecuteNonQuery();
                //Create the Items table
                Cmd.CommandText = "CREATE TABLE Items(ItemBarcode CHAR(14), Title VARCHAR(50),";
                Cmd.CommandText += " Author VARCHAR(45), Price MONEY, Collection VARCHAR(30), ItemLocation VARCHAR(20),";
                Cmd.CommandText += " PRIMARY KEY(ItemBarcode))";
                Cmd.ExecuteNonQuery();
                //Create the Loans table
                Cmd.CommandText = "CREATE TABLE Loans(LoanCode CHAR(14), BorrowerNumber CHAR(14), ItemBarcode CHAR(14),";
                Cmd.CommandText += " Issued DATE, LoanPolicy VARCHAR(25), LoanDue DATE,";
                Cmd.CommandText += " Complete VARCHAR(20), Primary Key(LoanCode),";
                Cmd.CommandText += " FOREIGN KEY(BorrowerNumber) REFERENCES Borrowers(BorrowerNumber),";
                Cmd.CommandText += " FOREIGN KEY(ItemBarcode) REFERENCES Items(ItemBarcode))";
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
            //causes whatever is entered as the password to be displayed as asterisks
            tbPassword.Text = "";
            tbPassword.PasswordChar = '*';

           
            
        }

        private void gbxLogInDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close(); //closes the form
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT * FROM Users WHERE Username ='" + tbUsername.Text + "'";//searches database for the username entered by the user
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)//if the username is found
            {
                reader.Read();
                if (tbPassword.Text == reader["Pword"].ToString())//compares password entered to the corresponding password in the databse
                {
                    //stores the user's username and password if correct
                    Username = tbUsername.Text;
                    Password = tbPassword.Text;
                    gbxLogInDetails.Hide();//reveals main menu
                    
                   
                    
                    
                }
                else
                {
                    MessageBox.Show("Wrong Password");//notifies user if password is incorrect
                }
            }
            else
            {
                MessageBox.Show("Username not found");//notifies user if username is incorrect
            }
            Conn.Close();
        }

        private void btBorrowers_Click(object sender, EventArgs e)
        {
            //form link to Borrowers.cs
            Borrowers FmB = new Borrowers();
            FmB.ShowDialog();

        }

        private void btLoans_Click(object sender, EventArgs e)
        {
            //form link to LoansMenu.cs
            LoansMenu FmLoansMenu = new LoansMenu();
            FmLoansMenu.ShowDialog();
        }

        private void btReports_Click(object sender, EventArgs e)
        {
            //form link to ReportsMenu.cs
            ReportsMenu FmReportsMenu = new ReportsMenu();
            FmReportsMenu.ShowDialog();
        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            //form link to Users.cs
            Users FmUsers = new Users();
            FmUsers.ShowDialog();
        }
    }
}
