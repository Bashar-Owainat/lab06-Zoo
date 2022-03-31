using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    abstract class Birds : WarmBlooded
    {
        public Boolean CoveredWithFeather = true;

        public Boolean GetCoveredWithFeather()
        {
            return CoveredWithFeather;
        }

    }
}
