using System;
using Xunit;
using ZooApp;

namespace ZooTests
{
    public class UnitTest1
    {
       // tests for lab 6

        [Fact]
        public void IsSubclass()
        {
           Assert.True( typeof(Dog).IsSubclassOf(typeof(Animal)));
        }
            

        [Fact]
        public void ExibitBehaivourFromBaseClass()
        {
            Dog doggy = new Dog();
            Horse horse = new Horse();

            Assert.Equal("Bark", doggy.Sound());
            Assert.Equal("friendly", horse.AttitudeWithHumans());
        }



    //tests for lab 7
        [Fact]
        public void InterfaceImplementation()
        {
            Dog doggy = new Dog();
            doggy.HomeVisit();

            Assert.Equal("we are on the way to check if you can adopt this dog", doggy.HomeVisit());
        }

        [Fact]
        public void Inheritance()
        {
            Dog doggy = new Dog();

            Assert.Equal("Bark", doggy.Sound());// inherited from Mammals
        }

        [Fact]
        public void Ploymorphism()
        {
            Dog husky = new SiberianHusky();  // SiberianHusky is a dog
            string input2 = "hair";
            husky.SetCoveredWithFurOrHair(input2);


            Assert.Equal("hair", husky.GetCoveredWithFurOrHair());
        }
    }
}
