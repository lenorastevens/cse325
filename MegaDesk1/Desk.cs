using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1
{
    internal class Desk
    {
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        string customerName;
        int deskWidth;
        int deskDepth;
        int numDrawers;
        string surfaceMaterial;
        int rushOrderDays;
        double totalPrice;

        public Desk(string name, int width, int depth, int drawers, string material, int rush) 
        {
            customerName = name;
            deskWidth = width;
            deskDepth = depth;
            numDrawers = drawers;
            surfaceMaterial = material;
            rushOrderDays = rush;
            totalPrice = 0;
        }

        public double calculateQuotePrice() 
        { 

            return totalPrice; 
        }
    }

    enum DesktopMaterial
    {
        Oak,
        Laminate,
        Rosewood,
        Veneer,
        Pine,
    }
}
