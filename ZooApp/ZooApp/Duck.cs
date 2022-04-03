using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Duck : Birds, IAdopt, IAoptable
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

        public string application
        {
            set; get;
        }

        public int AgeRequirements
        {
            set; get;
        }

        public int ApotionFee
        {
            set; get;
        }

        public string HomeVisit()
        {
            string message = "we are on the way to check if you can adopt this duck";
            Console.WriteLine(message);
            return message;
        }

        public Boolean friendly
        {
            set; get;
        }

        public Boolean goodWithKids
        {
            set; get;
        }
    }
}
