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
        public int width;
        public int depth;
        public int numDrawers;
        public DesktopMaterial material;
       
        public Desk() 
        {

        }

    }

    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine,
    }
}
