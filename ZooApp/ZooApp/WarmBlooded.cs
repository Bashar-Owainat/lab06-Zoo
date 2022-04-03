using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    //inherits Animal

        public abstract class WarmBlooded : Animal
    {
        public Boolean CanMaintainBodyTemp = true;

        public Boolean GetCanMaintainTemp()
        {
            return CanMaintainBodyTemp;
        } 
    }
}
