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
    public partial class AnnualReport : Form
    {
        public AnnualReport()
        {
            InitializeComponent();
        }
        private int SELECTResult(OleDbCommand Cmd)//function to execute the SQL and convert the value it returns to an integer
        {
            int a;
            MessageBox.Show(Cmd.CommandText);
            if (Cmd.ExecuteScalar() != DBNull.Value)
            {
                a = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            else
            {
                a = 0;
            }
            return a;
           
        }
        private void AnnualReport_Load(object sender, EventArgs e)
        {
            //should be working
            DateTime today = DateTime.Today;//today's date
            int ODY = today.Year - 1;//last year
            string ODYS = ODY.ToString(); string ODD = "11/11/" + ODYS;//the first loan due date that allows a loan to be long overdue in current year
            DateTime ODD1 = Convert.ToDateTime(ODD);//converts to date
            //MessageBox.Show(ODD1.ToString());
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            //SQL for finding loans that are long overdue
            Cmd.CommandText = "SELECT COUNT (COMPLETE) AS C FROM Loans WHERE (Complete = 'BRO' AND #" + today.AddDays(-51).ToString("MM/dd/yyyy") + "# >= LoanDue AND (YEAR(LoanDue) = "+ today.Year +" OR YEAR(LoanDue) = " + ODY + ") AND LoanDue >= #" + ODD1 + "#) ";
            Cmd.CommandText += "OR (Complete = 'No - On Loan' AND #" + today.AddDays(-51).ToString("MM/dd/yyyy") + "# >= LoanDue)" ;
            lbItemsValue.Text = SELECTResult(Cmd).ToString();
            //SQL for finding long overdue loans that have been recovered by the book recovery officer this year
            Cmd.CommandText = "SELECT COUNT (COMPLETE) AS C FROM Loans WHERE Complete = 'BRO' AND (YEAR(LoanDue) = " + today.Year + " OR Year(LoanDue) = " + ODY + ") AND LoanDue >= #" + ODD1 + "# ";
            lbItemsRecoveredValue.Text = SELECTResult(Cmd).ToString();
            //SQL for calculating the total cost of the loans recovered by the book recovery officer
            Cmd.CommandText = "SELECT SUM (Price) ";
            Cmd.CommandText += "FROM Loans, Items ";
            Cmd.CommandText += "WHERE Loans.ItemBarcode = Items.ItemBarcode AND ";
            Cmd.CommandText += "(Loans.Complete = 'BRO' AND YEAR(LoanDue) = " + today.Year + " OR Loans.Complete = 'BRO' AND LoanDue >= #" + ODD1 +"#)";
            double Result = SELECTResult(Cmd);
            lbCostRecoveredValue.Text = "£"+Result.ToString();
      
            


        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();//closes the form
        }
    }
}
