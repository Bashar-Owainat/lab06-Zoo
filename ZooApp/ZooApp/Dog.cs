using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Dog : Mammals
    {
        public override void Move()
        {
            Console.WriteLine("Walking");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating bones");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZzZzZzZ");
        }

        public override void Reproduce()
        {
            Console.WriteLine("Live Birth");
        }

        public override void Sound()
        {
            Console.WriteLine("Bark");
        }

        public override void AttitudeWithHumans()
        {
            Console.WriteLine("finendly");
        }

        public override void SetCoveredWithFurOrHair(String input)
        {

            this.CoveredWithFurOrHair = input;
           
        }
        public override string GetCoveredWithFurOrHair()
        {

            return this.CoveredWithFurOrHair;
        }
    }

}
