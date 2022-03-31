using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    abstract class Fishes : ColdBlooded
    {
        public string CoveredWithScales;
        public abstract void SetCoveredWithScales(string input); // abstract propetry



        public abstract string GetCoveredWithScales();

    }
}
