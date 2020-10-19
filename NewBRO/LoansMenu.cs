using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBRO
{
    public partial class LoansMenu : Form
    {
        public LoansMenu()
        {
            InitializeComponent();
        }

        private void LoansMenu_Load(object sender, EventArgs e)
        {

        }

        private void btNewLoan_Click(object sender, EventArgs e)
        {
            //form link to NewLoan.cs
            NewLoan FmNL = new NewLoan();
            FmNL.ShowDialog();
        }

        private void btCurrent_Click(object sender, EventArgs e)
        {
            //form link to CurrentLoans.cs
            CurrentLoans FmCL = new CurrentLoans();
            FmCL.ShowDialog();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close();//closes the form
        }
    }
}
