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

        public Desk Desk { get; set; }

        public List<DeskQuotes> Quotes {  get; private set; }
        public DeskQuotes() 
        {
            Quotes = new List<DeskQuotes>();
        }

        public void AddDesk(Desk desk)
        {
            DeskQuotes deskQuote = new DeskQuotes
            {
                Desk = desk               
            };

            Quotes.Add(deskQuote);
        }
        public decimal CalculateQuoteTotal()
        {
            decimal basePrice = BASE_PRICE;
            decimal surfaceAreaCost = CalculateSurfaceAreaCost();
            decimal drawersCost = Desk.NumDrawers * PER_DRAWER;
            decimal materialCost = CalculateMaterialCost();
            decimal rushOrderCost = CalculateRushOrderCost();

            return basePrice + surfaceAreaCost + drawersCost + materialCost + rushOrderCost;

        }
        private decimal CalculateSurfaceAreaCost()
        {
            int surfaceArea = Desk.Width * Desk.Depth;
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
            switch (Desk.Material)
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

            if (Desk.RushDays == 3)
            {
                rushOrderCost = CalculateAdditionalCost(60, 70, 80);
            }
            else if (Desk.RushDays == 5)
            {
                rushOrderCost = CalculateAdditionalCost(40, 50, 60);
            }
            else if (Desk.RushDays == 7)
            {
                rushOrderCost = CalculateAdditionalCost(30, 35, 40);
            }

            return rushOrderCost;
        }

        private decimal CalculateAdditionalCost(decimal sizeLess1000, decimal size1000to2000, decimal sizeGreaterThan2000)
        {
            int surfaceArea = Desk.Width * Desk.Depth;
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

        public decimal CalculateTotalForDesk(int deskIndex)
        {
            if (deskIndex >= 0 && deskIndex < Quotes.Count)
            {
                return Quotes[deskIndex].CalculateQuoteTotal();
            }
            else
            {
                return 0;
            }
        }

        public decimal CalculateTotalForAllDesks()
        {
            decimal total = 0;

            foreach (var quote in Quotes)
            {
                total += quote.CalculateQuoteTotal();
            }

            return total;
        }
    }
}
