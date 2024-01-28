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
    public partial class DisplayQuote : Form
    {
        List<Desk> desks = new List<Desk>();
        public decimal QuoteTotal;

        public DisplayQuote(decimal quoteTotal)
        {
            InitializeComponent();
        }
        

        private void CloseDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }

}
