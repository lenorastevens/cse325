using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1
{    
    internal class DeskQuotes
    {
        public const int BASE_PRICE = 200;
        public const int PER_DRAWER = 50;

        public const decimal PER_INCH_OVER = 1;
        public const decimal OAK_COST = 200;
        public const decimal LAMINATE_COST = 100;
        public const decimal PINE_COST = 50;
        public const decimal ROSEWOOD_COST = 300;
        public const decimal VENEER_COST = 125;

        public string quoteDate = "";
        public Desk newDesk = new Desk();
        public string name = "";
        public int rushDays = 0;


        public List<DeskQuotes> quotesList; 
        

        public DeskQuotes() 
        {
            
        }

        public void AddDesk(Desk desk)
        {
           
        }
        public decimal CalculateQuoteTotal()
        {
            decimal basePrice = BASE_PRICE;
            decimal surfaceAreaCost = CalculateSurfaceAreaCost();
            decimal drawersCost = newDesk.numDrawers * PER_DRAWER;
            decimal materialCost = CalculateMaterialCost();
            decimal rushOrderCost = CalculateRushOrderCost();

            return basePrice + surfaceAreaCost + drawersCost + materialCost + rushOrderCost;

        }
        private decimal CalculateSurfaceAreaCost()
        {
            int surfaceArea = newDesk.width * newDesk.depth;
            int threshold = 1000;
            if (surfaceArea > threshold)
            {
                return (surfaceArea - threshold) * PER_INCH_OVER;
            }
            else
            {
                return 0;
            }
        }

        private decimal CalculateMaterialCost()
        {
            switch (newDesk.material)
            {
                case DesktopMaterial.Oak:
                    return OAK_COST;
                case DesktopMaterial.Laminate:
                    return LAMINATE_COST;
                case DesktopMaterial.Pine:
                    return PINE_COST;
                case DesktopMaterial.Rosewood:
                    return ROSEWOOD_COST;
                case DesktopMaterial.Veneer:
                    return VENEER_COST;
                default:
                    return 0;
            }
        }

        private decimal CalculateRushOrderCost()
        {
            decimal rushOrderCost = 0;

            if (rushDays == 3)
            {
                rushOrderCost = CalculateAdditionalCost(60, 70, 80);
            }
            else if (rushDays == 5)
            {
                rushOrderCost = CalculateAdditionalCost(40, 50, 60);
            }
            else if (rushDays == 7)
            {
                rushOrderCost = CalculateAdditionalCost(30, 35, 40);
            }

            return rushOrderCost;
        }

        private decimal CalculateAdditionalCost(decimal sizeLess1000, decimal size1000to2000, decimal sizeGreaterThan2000)
        {
            int surfaceArea = newDesk.width * newDesk.depth;
            if (surfaceArea < 1000)
            {
                return sizeLess1000;
            }
            else if (surfaceArea <= 2000)
            {
                return size1000to2000;
            }
            else
            {
                return sizeGreaterThan2000;
            }
        }

    }
}
