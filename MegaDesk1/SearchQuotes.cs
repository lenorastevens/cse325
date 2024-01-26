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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void CloseSearchButton_Click(object sender, EventArgs e)
        {
            MegaDesk viewMegaDesk = (MegaDesk)Tag;
            viewMegaDesk.Show();
            Close();
        }
    }
}
