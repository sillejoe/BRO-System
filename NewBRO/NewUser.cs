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
using SampleLibrary;//links form to SampleLibrary

namespace NewBRO
{
    public partial class NewUser : Form
    {
        InputValidation IV = new InputValidation();//creates an object using the InputValidation class from SampleLibrary
        bool temp; int count = 0;
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
        public void LengthCheck2(string textbox, int length, bool temp, ref int count)//Procedure for checking the length of an input
        {
            temp = IV.LengthCheck2(textbox, length);//uses the method found in SampleLibrary to check length
            if (temp == true)
            {
                count++;//increments count if the length is valid
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            //SQL for checking whether the username entered by the user already exists
            Cmd.CommandText = "SELECT Username FROM Users WHERE Username ='" + tbUsername.Text + "'";
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Username already exists");//notifies the user if the username already exists
            }
            else
            {
                Conn.Close(); Conn.Open();
                //if the username is unique it checks the password
                Cmd.CommandText = "SELECT PWord FROM Users WHERE PWord ='" + tbPassword.Text + "'";
                OleDbDataReader reader1 = Cmd.ExecuteReader();
                if (reader1.HasRows)
                {
                    MessageBox.Show("Please enter a different password");
                }
                else
                {
                    if(IV.Null(tbUsername.Text) == true)//checks whether a username has been entered using the method in SampleLibrary
                    {
                        MessageBox.Show("Please enter a username");
                    }
                    else
                    {
                        count++;//count is incremented if a username has been entered
                    }
                    if (IV.Null(tbPassword.Text) == true)//checks whether the user has entered a password
                    {
                        MessageBox.Show("Please enter a password");
                    }
                    else
                    {
                        count++;//count is incremented if a password has been entered
                    }
                    LengthCheck2(tbUsername.Text, 10, temp, ref count);//checks the length of the username
                    LengthCheck2(tbPassword.Text, 15, temp, ref count);//checks the length of the password
                    if(count == 4)//count = 4 if all of the inputs are vallid
                    {
                        Conn.Close();
                        Conn.Open();
                        //SQL to add the user to the database
                        Cmd.CommandText = "INSERT INTO Users ";
                        Cmd.CommandText += " VALUES('" + tbUsername.Text + "', '" + tbPassword.Text + "')";
                        //MessageBox.Show(Cmd.CommandText);
                        Cmd.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show("User Created");
                    }
                    else
                    {
                        MessageBox.Show("Please make sure that everything entered is valid");//error message
                    }
                }
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();//closes form
        }
    }
}
