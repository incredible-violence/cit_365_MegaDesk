using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_BradKellogg
{
    class DeskQuote
    {
        private string firstName;
        private string lastName;
        private int rushDays;
        private float quote;
        private DateTime orderDate;

        public DeskQuote(string firstName, string lastName, int rushDays, DateTime orderDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.rushDays = rushDays;
            this.orderDate = orderDate;
        }

        public string getfirstName()
        {
            return firstName;
        }

        public string getlastNAme()
        {
            return lastName;
        }

        public int getRushDays()
        {
            return rushDays;
        }

        public float getQuote()
        {
            return quote;
        }

        public DateTime getOrderDate()
        {
            return orderDate;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void setRushDays(int rushDays)
        {
            this.rushDays = rushDays;
        }

        public void setQuote(float quote)
        {
            this.quote = quote;
        }

        public void setOrderDate()
        {
            this.orderDate = new DateTime();
        }

        public float calcRushPrice(int width, int depth)
        {
            float price = 0;

            switch (rushDays)
            {
                case 3:
                    if (width * depth < 1000)
                    {
                        price += 60;
                    }
                    else if (width * depth > 2000)
                    {
                        price += 80;
                    }
                    else
                    {
                        price += 70;
                    }
                    break;
                case 5:
                    if (width * depth < 1000)
                    {
                        price += 40;
                    }
                    else if (width * depth > 2000)
                    {
                        price += 60;
                    }
                    else
                    {
                        price += 50;
                    }
                    break;
                case 7:
                    if (width * depth < 1000)
                    {
                        price += 30;
                    }
                    else if (width * depth > 2000)
                    {
                        price += 40;
                    }
                    else
                    {
                        price += 35;
                    }
                    break;
                default:
                    price = 0;
                    break;
            }

            return price;
        }

        public void outputToFile(string filePath)
        {
            string output = firstName + ' ' + lastName + '\t' + rushDays + '\t' + quote + '\t' + orderDate + Environment.NewLine;
            System.IO.File.AppendAllText(@filePath, output);
        }
    }
}
