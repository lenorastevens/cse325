using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1
{
    public partial class AddNewQuote : Form
    {
        public AddNewQuote()
        {
            InitializeComponent();
        }

        private void CloseAddNewQuoteButton_Click(object sender, EventArgs e)
        {
            MegaDesk openMegaDesk = (MegaDesk)Tag;
            openMegaDesk.Show();
            Close();
        }
    }
}
