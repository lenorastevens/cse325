using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MegaDesk1
{
    internal partial class AddNewQuote : Form
    {
        private DeskQuotes deskQuotesInstance;
        public AddNewQuote()
        {
            InitializeComponent();

            deskQuotesInstance = new DeskQuotes();
        }

        private void CloseAddNewQuoteButton_Click(object sender, EventArgs e)
        {
            MegaDesk openMegaDesk = (MegaDesk)Tag;
            openMegaDesk.Show();
            Close();
        }

        private void CustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerName.Text))
            {
                e.Cancel = true; // Prevent focus change
                errorProvider1.SetError(CustomerName, "Please enter a name."); // Display error message
            }
            else
            {
                e.Cancel = false; // Allow focus change
                errorProvider1.SetError(CustomerName, ""); // Clear error message
            }
        }

        private void DeskWidth_Validating(object sender, CancelEventArgs e)
        {
           
            int minWidth = 24;
            int maxWidth = 96;

            if (!int.TryParse(DeskWidth.Text, out int width) || width < minWidth || width > maxWidth)
            {
                e.Cancel = true; 
                errorProvider1.SetError(DeskWidth, $"Width needs to be an integer between {minWidth} and {maxWidth}.");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(DeskWidth, "");
            }
        }

        private void DeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void DeskDepth_Validating(object sender, CancelEventArgs e)
        {
            int minDepth = 12;
            int maxDepth = 48;

            if (!int.TryParse((sender as TextBox).Text, out int depth) || depth < minDepth || depth > maxDepth)
            {
                errorProvider1.SetError((sender as TextBox), $"Depth needs to be an integer between {minDepth} and {maxDepth}.");
            }
            else
            {
                errorProvider1.SetError((sender as TextBox), ""); // Clear the error message
            }
        }

        private void Material_Validating(object sender, CancelEventArgs e)
        {
            if (Material.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(Material, "Please select a surface Material.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Material, "");
            }
        }

        private void RushSelection_Validating(object sender, CancelEventArgs e)
        {
            if (RushSelection.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(RushSelection, "Please select a surface Material.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(RushSelection, "");
            }
        }

        private void SubmitQuote_Click(object sender, EventArgs e)
        {
            var materials = Enum.GetValues(typeof(DesktopMaterial));
            Material.DataSource = materials;
            Material.DisplayMember = "";

            int[] Array = { 0, 3, 5, 7 };
            int index = RushSelection.SelectedIndex;

            DeskQuotes quote = new DeskQuotes();
            quote.name = CustomerName.Text;
            quote.quoteDate = QuoteDate.Text;
            quote.newDesk.width = int.Parse(DeskWidth.Text);
            quote.newDesk.depth = int.Parse(DeskDepth.Text);
            quote.newDesk.numDrawers = (int)NumDrawers.Value;
            quote.newDesk.material = (DesktopMaterial)Material.SelectedItem;
            quote.rushDays = Array[index];
            decimal price = quote.CalculateQuoteTotal();
            
            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.displayQuoteData(quote.name, price, quote.quoteDate);
                  
            
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show();
            this.Hide();
   
        }

        
    }
}
