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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }
        public DateTime today = DateTime.Today;

        private void NoForMonth(OleDbCommand Cmd, ref int Month, DateTime StartOfMonth, DateTime EndOfMonth)//runs the SQL for calculating how many loans became long overdue for a specific month
        {
            Cmd.CommandText = "SELECT COUNT (COMPLETE) AS C FROM Loans WHERE (Complete = 'No - On Loan' OR Complete = 'BRO') ";
            Cmd.CommandText += "AND LoanDue >= #" + StartOfMonth.AddDays(-51).ToString("MM/dd/yyyy") + "# AND LoanDue <= #" + EndOfMonth.AddDays(-51).ToString("MM/dd/yyyy") + "#";
            MessageBox.Show(Cmd.CommandText);
            if (Cmd.ExecuteScalar() != DBNull.Value)
            {
                 Month = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            else
            {
                Month = 0;
            }
            
        }
        private void Graph_Load(object sender, EventArgs e)
        {
            int jan = 0, feb = 0, march = 0, april = 0, may = 0, june = 0, july = 0, aug = 0, sep = 0, oct = 0, nov = 0, dec = 0;
            int LastYear = today.Year - 1;
            //calculates the first and final date for each month from last year
            string LastYearString = LastYear.ToString(); string LastJanString = "31/01/" + LastYearString;
            DateTime LastJanDate = Convert.ToDateTime(LastJanString); DateTime StartOfLastJan = LastJanDate.AddDays(-30);
            DateTime LastFebDate = LastJanDate.AddMonths(1); DateTime StartOfLastFeb = StartOfLastJan.AddMonths(1);
            DateTime LastMarchDate;
            if (LastFebDate.ToString().Contains("28"))//takes into account leap years for february date
            {
                LastMarchDate = LastFebDate.AddMonths(1).AddDays(3);
            }
            else
            {
                LastMarchDate = LastFebDate.AddMonths(1).AddDays(2);
            }
            DateTime StartOfLastMarch = StartOfLastFeb.AddMonths(1);
            DateTime LastAprilDate = LastMarchDate.AddMonths(1); DateTime StartOfLastApril = StartOfLastMarch.AddMonths(1);
            DateTime LastMayDate = LastAprilDate.AddMonths(1).AddDays(1); DateTime StartOfLastMay = StartOfLastApril.AddMonths(1);
            DateTime LastJuneDate = LastMayDate.AddMonths(1); DateTime StartOfLastJune = StartOfLastMay.AddMonths(1);
            DateTime LastJulyDate = LastJuneDate.AddMonths(1).AddDays(1); DateTime StartOfLastJuly = StartOfLastJune.AddMonths(1);
            DateTime LastAugustDate = LastJulyDate.AddMonths(1); DateTime StartOfLastAugust = StartOfLastJuly.AddMonths(1);
            DateTime LastSeptemberDate = LastAugustDate.AddMonths(1); DateTime StartOfLastSeptember = StartOfLastAugust.AddMonths(1);
            DateTime LastOctoberDate = LastSeptemberDate.AddMonths(1).AddDays(1); DateTime StartOfLastOctober = StartOfLastSeptember.AddMonths(1);
            DateTime LastNovemberDate = LastOctoberDate.AddMonths(1); DateTime StartOfLastNovember = StartOfLastOctober.AddMonths(1);
            DateTime LastDecemberDate = LastNovemberDate.AddMonths(1).AddDays(1); DateTime StartOfLastDecember = StartOfLastNovember.AddMonths(1);

          
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            //uses the procedure to calculate how many items became overdue in each of the months
            NoForMonth(Cmd, ref jan, StartOfLastJan, LastJanDate);
            NoForMonth(Cmd, ref feb, StartOfLastFeb, LastFebDate);
            NoForMonth(Cmd, ref march, StartOfLastMarch, LastMarchDate);
            NoForMonth(Cmd, ref april, StartOfLastApril, LastAprilDate);
            NoForMonth(Cmd, ref may, StartOfLastMay, LastMayDate);
            NoForMonth(Cmd, ref june, StartOfLastJune, LastJuneDate);
            NoForMonth(Cmd, ref july, StartOfLastJuly, LastJulyDate);
            NoForMonth(Cmd, ref aug, StartOfLastAugust, LastAugustDate);
            NoForMonth(Cmd, ref sep, StartOfLastSeptember, LastSeptemberDate);
            NoForMonth(Cmd, ref oct, StartOfLastOctober, LastOctoberDate);
            NoForMonth(Cmd, ref nov, StartOfLastNovember, LastNovemberDate);
            NoForMonth(Cmd, ref dec, StartOfLastDecember, LastDecemberDate);

            //creates an array to store the months and their corresponding values
            string[,] XYValues = new string[12, 2] { { "Janaury", jan.ToString() }, { "February", feb.ToString() }, { "March", march.ToString() }, { "April", april.ToString() }, { "May", may.ToString() }, { "June", june.ToString() }, { "July", July.ToString() }, { "August", aug.ToString() }, { "September", sep.ToString() }, { "October", oct.ToString() }, { "November", nov.ToString() }, { "December", dec.ToString() } }; 
            //formats the graph
            this.dgvForGraph.Rows.Add(jan, feb, march, april, may, june, july, aug, sep, oct, nov, dec);
            chart1.ChartAreas[0].AxisY.Maximum = 25;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            //adds values to the graph using the array
            for (int i=0; i < 12; i++)
            {
                chart1.Series["Overdue Loans"].Points.AddXY(XYValues[i,0], XYValues[i,1]);

            }



        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();//closes the form
        }
    }
}
