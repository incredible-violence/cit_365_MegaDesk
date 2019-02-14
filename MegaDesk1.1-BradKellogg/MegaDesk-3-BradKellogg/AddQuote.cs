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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            int spaceIndex = nameInput.Text.IndexOf(' ');
            string tempfName = nameInput.Text.Substring(0, spaceIndex);
            string tempLName = nameInput.Text.Substring(spaceIndex + 1);

            Desk desk = new Desk(Int32.Parse(widthInput.Text), Int32.Parse(depthInput.Text), Int32.Parse(drawersInput.Text));
            desk.setMaterial(materialComboBox.Text);

            DeskQuote quote = new DeskQuote(tempfName, tempLName, Int32.Parse(rushComboBox.Text), DateTime.Now);
            quote.setQuote(quote.calcRushPrice(desk.getWidth(), desk.getDepth()) + desk.calcDeskPrice());

            quote.outputToFile("C:\\Users\\Brad\\source\\repos\\MegaDesk1.1-BradKellogg\\MegaDesk-3-BradKellogg\\quotes.txt");

            quote.outputToJson("", quote);

            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        public bool ValidWidth(string width, out string errorMessage)
        {
            int temp = 0;

            // Parsing failed
            if (!Int32.TryParse(width, out temp))
            {
                errorMessage = "Width must be a number.";
                return false;
            }

            // Confirm that the width field is not empty.
            if (width.Length == 0)
            {
                errorMessage = "Width is required.";
                return false;
            }

            if (temp < 24)
            {
                errorMessage = "Width must be 24 - 96 inches.";
                return false;
            } else if (temp > 96)
            {
                errorMessage = "Width must be 24 - 96 inches.";
                return false;
            } else
            {
                errorMessage = "";
                return true;
            }
        }

        public bool ValidDepth(string depth, out string errorMessage)
        {
            int temp = 0;

            // Parsing failed
            if (!Int32.TryParse(depth, out temp))
            {
                errorMessage = "Depth must be a number.";
                return false;
            }

            // Confirm that the depth field is not empty.
            if (depth.Length == 0)
            {
                errorMessage = "Depth is required.";
                return false;
            }

            if (temp < 12)
            {
                errorMessage = "Depth must be 12 - 48 inches.";
                return false;
            }
            else if (temp > 48)
            {
                errorMessage = "Depth must be 12 - 48 inches.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        public bool ValidDrawers(string drawers, out string errorMessage)
        {
            int temp = 0;

            // Parsing failed
            if (!Int32.TryParse(drawers, out temp))
            {
                errorMessage = "Number of drawers must be a number.";
                return false;
            }

            // Confirm that the height field is not empty.
            if (drawers.Length == 0)
            {
                errorMessage = "Number of drawers is required.";
                return false;
            }

            if (temp < 0)
            {
                errorMessage = "Number of drawers must be 0 - 7.";
                return false;
            }
            else if (temp > 7)
            {
                errorMessage = "Number of drawers must be 0 - 7.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(widthInput.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                widthInput.Select(0, widthInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.widthErrorProvider.SetError(widthInput, errorMsg);
            }
        }

        private void DepthInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(depthInput.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                depthInput.Select(0, depthInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.depthErrorProvider.SetError(depthInput, errorMsg);
            }
        }

        private void DrawersInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDrawers(drawersInput.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                drawersInput.Select(0, drawersInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.drawersErrorProvider.SetError(drawersInput, errorMsg);
            }
        }

        private void WidthInput_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            widthErrorProvider.SetError(widthInput, "");
        }

        private void DepthInput_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            depthErrorProvider.SetError(depthInput, "");
        }

        private void DrawersInput_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            drawersErrorProvider.SetError(drawersInput, "");
        }

        private void HeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                heightInput.Text = heightInput.Text.Substring(0, heightInput.Text.Length - 1);
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
