using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_BradKellogg
{
    enum Material { Laminate, Oak, Rosewood, Veneer, Pine };

    class Desk
    {
        private int width;
        private int depth;
        private int numDrawers;
        private Material deskMaterial;

        public Desk(int width, int depth, int numDrawers)
        {
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
        }

        public int getWidth()
        {
            return width;
        }

        public int getDepth()
        {
            return depth;
        }

        public int getNumDrawers()
        {
            return numDrawers;
        }

        public Material getDeskMaterial()
        {
            return deskMaterial;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public void setDepth(int depth)
        {
            this.depth = depth;
        }

        public void setNumDrawers(int number)
        {
            this.numDrawers = number;
        }

        public void setMaterial(string material)
        {
            switch (material)
            {
                case "Laminate":
                    this.deskMaterial = Material.Laminate;
                    break;
                case "Oak":
                    this.deskMaterial = Material.Oak;
                    break;
                case "Rosewood":
                    this.deskMaterial = Material.Rosewood;
                    break;
                case "Veneer":
                    this.deskMaterial = Material.Veneer;
                    break;
                case "Pine":
                    this.deskMaterial = Material.Pine;
                    break;
                default:
                    Console.WriteLine("Invalid desk material: " + material);
                    break;
            }
        }

        public float calcDeskPrice()
        {
            float price = 200;

            if (width * depth > 1000)
            {
                price += width * depth;
            }

            price += numDrawers * 50;

            switch (deskMaterial) 
            {
                case Material.Oak:
                    price += 200;
                    break;
                case Material.Laminate:
                    price += 100;
                    break;
                case Material.Pine:
                    price += 50;
                    break;
                case Material.Rosewood:  
                    price += 300;
                    break;
                case Material.Veneer:
                    price += 125;
                    break;
                default:
                    Console.WriteLine("Invalid desk material");
                    break;
            }

            return price;
       }
    }
}
