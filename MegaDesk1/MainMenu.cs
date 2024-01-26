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

        private void AddQuotesButton_Click(object sender, EventArgs e)
        {
            AddQuotes viewAddQuotes = new AddQuotes();
            viewAddQuotes.Tag = this;
            viewAddQuotes.Show(this);
            Hide();
        }

        private void ViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes seeAllQuotes = new ViewAllQuotes();
            seeAllQuotes.Tag = this;
            seeAllQuotes.Show(this);
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }
    }
}
