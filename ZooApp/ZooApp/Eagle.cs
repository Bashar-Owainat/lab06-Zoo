using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Eagle : Birds
    {

        public override void Move()
        {
            Console.WriteLine("Flying");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating fish");
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
