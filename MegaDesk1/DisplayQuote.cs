using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1
{
    internal partial class DisplayQuote : Form
    {
        public List<DeskQuotes> deskquote = new List<DeskQuotes>();
      


        public DisplayQuote()
        {
            InitializeComponent();
        }
        public DisplayQuote(string name, decimal price, string date)
        { 
        }


        private void CloseDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            AddNewQuote newQuote = (AddNewQuote)Tag;
            newQuote.Show();
            Close();
        }

        
        public string displayQuoteData(string name, decimal price, string date)
        {
            CustomerLabel.Text = name;
            CurrentPrice.Text = "$" + price.ToString("N2");
            CurrentDate.Text = date;

            return "Data receieved successfully!";
        }

    }

}
