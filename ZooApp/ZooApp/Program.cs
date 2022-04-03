using System;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog1 = new Dog();
            dog1.HomeVisit();
            string input = "fur";
            dog1.SetCoveredWithFurOrHair(input);

            dog1.Eat();
            Console.WriteLine(dog1.GetCoveredWithFurOrHair());
            Console.WriteLine(dog1.GetCanMaintainTemp());
            dog1.Sound();

            Duck duck1 = new Duck();
            duck1.Eat();


            Eagle eagle1 = new Eagle();
            eagle1.Move();

            Horse horse1 = new Horse();
            horse1.Sleep();

            Swordfish swordfish1 = new Swordfish();
            swordfish1.Eat();


            Dog husky = new SiberianHusky();  // polymorphism
            string input2 = "hair";
            husky.SetCoveredWithFurOrHair(input2);
            Console.WriteLine(husky.GetCoveredWithFurOrHair());


        }
    }
}
