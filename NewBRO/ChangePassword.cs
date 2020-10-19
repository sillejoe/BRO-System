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
    public partial class ChangePassword : Form
    {
        InputValidation IV = new InputValidation();//new instance of the InputValidation class
        bool temp; int count = 0;
        public string username, password;
        public void LengthCheck2(string textbox, int length, bool temp, ref int count)//procedure to check the length of inputs 
        {
            temp = IV.LengthCheck2(textbox, length);//checks input length using method from SampleLibrary
            if (temp == true)
            {
                count++;//count incremented if length is valid 
            }
        }
        public ChangePassword()
        {
            InitializeComponent();
            username = Form1.Username; //username = the username used to log in to the program with
            password = Form1.Password; //password = the password used to log in to the program with
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == tbCPassword.Text)//checks whether password and confirm password are the same
            {
                OleDbConnection Conn = new OleDbConnection(Program.ConnString);
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "SELECT PWord FROM Users WHERE PWord = '" + tbPassword.Text + "'";
                OleDbDataReader reader = Cmd.ExecuteReader();
                if (reader.HasRows)//checks whether the password exists
                {
                    MessageBox.Show("Please enter a different password");
                    Conn.Close();
                }
                else
                {
                    if(IV.Null(tbPassword.Text) == true)//checks whether a password has been entered
                    {
                        MessageBox.Show("Please enter a password");
                    }
                    else
                    {
                        count++;
                    }
                    if(IV.Null(tbCPassword.Text) == true)//checks whether the user has confirmed the password
                    {
                        MessageBox.Show("Please confirm password");

                    }
                    else
                    {
                        count++;
                    }
                    LengthCheck2(tbPassword.Text, 15, temp, ref count);//checks length of the password
                    LengthCheck2(tbCPassword.Text, 15, temp, ref count);//checks length of the confirmed password
                    if (count == 4)//count = 4 if all inputs are valid
                    {
                        Conn.Close(); Conn.Open();
                        //SQL to update the current user's password
                        Cmd.CommandText = "UPDATE Users ";
                        Cmd.CommandText += "SET PWord = '" + tbPassword.Text + "'";
                        Cmd.CommandText += "WHERE Username = '" + username + "'";
                        Cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Changed");
                        password = tbPassword.Text;//changes the password stored in the program to the updated one
                        Form1.Password = tbPassword.Text;
                        tbPassword.Text = String.Empty; tbCPassword.Text = String.Empty;//resets the text boxes
                    }
                    else
                    {
                        MessageBox.Show("Please make sure that nothing is empty and everything you have entered is valid");//error message
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please make sure passwords are the same");
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();//closes the form
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
                
        }
    }
}
