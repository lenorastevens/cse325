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

        private void deskWidth_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true; 
            }
        }


        private void SubmitQuote_Click(object sender, EventArgs e)
        {
            
            

            if (int.TryParse(DeskWidth.Text, out int width) && int.TryParse(DeskDepth.Text, out int depth))
            {
                var materials = Enum.GetValues(typeof(DesktopMaterial));
                Material.DataSource = materials;

                Material.DisplayMember = "";
                DesktopMaterial material= (DesktopMaterial)Material.SelectedItem;
                string date = QuoteDate.Text.ToString();
                int[] Array = { 0, 3, 5, 7 };
                int index= RushSelection.SelectedIndex;

                Desk newDesk = new Desk
                {
                    Datequote = date,
                    CustomerName = CustomerName.Text,
                    Width = width,
                    Depth = depth,
                    NumDrawers = (int)NumDrawers.Value,
                    Material = material,
                    RushDays = Array[index]
            };



                

                DeskQuotes newQuote = new DeskQuotes();
                newQuote.AddDesk(newDesk);
                

                decimal quoteTotal = newQuote.CalculateQuoteTotal();

                
                DisplayQuote displayQuoteForm = new DisplayQuote(quoteTotal);

                displayQuoteForm.Show();
            }

            else
            {
                MessageBox.Show("Invalid desk width or depth entered.");
            }
            


        }
    }
}
