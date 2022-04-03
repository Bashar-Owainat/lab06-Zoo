using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    interface IAdopt
    {
        string application
        {
            set; get;
        }

        int AgeRequirements
        {
            set; get;
        }

        int ApotionFee
        {
            set; get;
        }

        string HomeVisit();

    }
}
