using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Swordfish : Fishes
    {
        public override void Move()
        {
            Console.WriteLine("swimming");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating squids");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZzZzZzZ");
        }

        public override void Reproduce()
        {
            Console.WriteLine("laying eggs");
        }
        public override void SetCoveredWithScales(string input)
        {
            this.CoveredWithScales = input;

        }

        public override string GetCoveredWithScales()
        {
            return this.CoveredWithScales;
        }


    }
}
