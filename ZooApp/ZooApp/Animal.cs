using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public abstract class Animal
    {
        //abstraction
        public abstract void Move();

        public abstract void Eat();

        public abstract void Sleep();

        public abstract void Reproduce();
    }
}
