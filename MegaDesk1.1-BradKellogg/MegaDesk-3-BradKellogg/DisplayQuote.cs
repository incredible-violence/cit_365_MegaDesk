using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BradKellogg
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            // add content to displayQuoteBox here
            CustomerOutputLabel.Text = quote.getCustomerName();
            PriceOutLabel.Text = Convert.ToString(quote.getQuoteAmount());
            RushOutLabel.Text = Convert.ToString(quote.getRushDays());
            
        }
        
        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void backButton_SearchQuotes_Click(object sender, EventArgs e)
        {
            var quoteMenu = (AddQuote)Tag;
            quoteMenu.Show();
            Close();
        }

        private void QuoteLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Tag = this;
            main.Show(this);
            Hide();
            //var mainMenu = (MainMenu)Tag;
            //mainMenu.Show();
            //Close();
        }
    }
}
