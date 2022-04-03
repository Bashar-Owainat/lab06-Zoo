using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class SiberianHusky : Dog
    {
        public string  MakesNoise = "More than other dogs Huskies make a lot of noise";

        public string GetMakeNoise()
        {
            return MakesNoise;
        }
    }
}
