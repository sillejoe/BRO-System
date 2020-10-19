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
    public partial class Borrowers : Form
    {
        public Borrowers()
        {
            InitializeComponent();
        }

        private void Borrowers_Load(object sender, EventArgs e)
        {
         

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            //form link to BorrowersNew.cs
            BorrowersNew FmNewB = new BorrowersNew();
            FmNewB.ShowDialog();


        }

        private void btExisting_Click(object sender, EventArgs e)
        {
            //form link to BorrowersExisting.cs
            BorrowersExisting FmExistingB = new BorrowersExisting();
            FmExistingB.ShowDialog();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Close(); //closes form
        }
    }
}
