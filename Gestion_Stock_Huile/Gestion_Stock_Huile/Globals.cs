using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Huile
{
    public static class Globals
    {
        static HuileMetier huileMetier;
        static Globals()
        {
            HuileMetier = new HuileMetier();
        }

        internal static HuileMetier HuileMetier { get => huileMetier; set => huileMetier = value; }
    }
}
