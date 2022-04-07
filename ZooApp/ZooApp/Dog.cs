using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
       public class Dog : Mammals, IAdopt, IAoptable
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

        public override string Sound()
        {
            string sound = "Bark";
            Console.WriteLine(sound);
            return sound;
        }

        public override string AttitudeWithHumans()
        {
            string attitude = "friendly";
            Console.WriteLine(attitude);
            return attitude;
        }

        public override void SetCoveredWithFurOrHair(String input)
        {

            this.CoveredWithFurOrHair = input;
           
        }
        public override string GetCoveredWithFurOrHair()
        {

            return this.CoveredWithFurOrHair;
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
            string message = "we are on the way to check if you can adopt this dog";
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
