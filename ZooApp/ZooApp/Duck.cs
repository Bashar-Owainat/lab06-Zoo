using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Duck : Birds
    {
        public override void Move()
        {
            Console.WriteLine("swimming");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating grains");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZzZzZzZ");
        }

        public override void Reproduce()
        {
            Console.WriteLine("Eggs");
        }
    }
}
