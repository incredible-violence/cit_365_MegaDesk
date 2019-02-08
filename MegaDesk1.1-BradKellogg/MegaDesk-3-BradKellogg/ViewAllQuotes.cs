using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BradKellogg
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            if (new FileInfo("C:\\Users\\Brad\\source\\repos\\MegaDesk1.1-BradKellogg\\MegaDesk-3-BradKellogg\\quotes.txt").Length > 0)
            {
                List<string> lines = File
                    .ReadLines("C:\\Users\\Brad\\source\\repos\\MegaDesk1.1-BradKellogg\\MegaDesk-3-BradKellogg\\quotes.txt")
                    .Select(line => line.TrimEnd('#'))
                    .ToList();
                quotesListBox.DataSource = lines;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
