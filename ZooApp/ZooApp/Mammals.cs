using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
     public abstract class Mammals : WarmBlooded
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

        public virtual string Sound()
        {
            string sound = "This differes according to the animal";
            Console.WriteLine(sound);
            return sound;
        }
        public virtual string AttitudeWithHumans()
        {
            string attitde = "This differes according to the animal";
            Console.WriteLine(attitde);
            return attitde;
        }
    }
}
