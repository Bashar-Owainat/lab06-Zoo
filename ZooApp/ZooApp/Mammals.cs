using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
     abstract class Mammals : WarmBlooded
    {
        public string CoveredWithFurOrHair;
      

        public virtual void SetCoveredWithFurOrHair(string input)
        {

            this.CoveredWithFurOrHair = "depends on the animal";
        }
        public virtual string GetCoveredWithFurOrHair()
        {

            return this.CoveredWithFurOrHair;
        }

        public virtual void Sound()
        {
            Console.WriteLine("This differes according to the animal");
        }
        public virtual void AttitudeWithHumans()
        {
            Console.WriteLine("This differes according to the animal");
        }
    }
}
