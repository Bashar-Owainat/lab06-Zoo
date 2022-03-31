using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Horse : Mammals
    {
        public override void Move()
        {
            Console.WriteLine("Walking");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating grass");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZzZzZzZ");
        }

        public override void Reproduce()
        {
            Console.WriteLine("Live Birth");
        }

   
    }
}
