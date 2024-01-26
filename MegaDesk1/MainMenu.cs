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
    public partial class MegaDesk : Form
    {
        public MegaDesk()
        {
            InitializeComponent();
        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddNewQuote openAddNewQuote = new AddNewQuote();
            openAddNewQuote.Tag = this;
            openAddNewQuote.Show(this);
            Hide();
        }

        private void ViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes openViewAllQuotes = new ViewAllQuotes();
            openViewAllQuotes.Tag = this;
            openViewAllQuotes.Show(this);
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes openSearchQuotes = new SearchQuotes();
            openSearchQuotes.Tag = this;
            openSearchQuotes.Show(this);
            Hide();
        }
    }
}
