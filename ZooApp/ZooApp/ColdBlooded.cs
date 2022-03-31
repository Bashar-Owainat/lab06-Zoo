using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{

    //inherits Animal
    
    
    abstract class ColdBlooded : Animal
    {
        public Boolean CanNotMaintainBodyTemp = true;

        public Boolean GetCanNotMaintainTemp()
        {
            return CanNotMaintainBodyTemp;
        }
    }
}
