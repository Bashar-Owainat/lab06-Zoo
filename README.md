# lab06-Zoo

This app represents a Zoo that has 3 type of animals Maamals, Birds and Fishes.
From Mammals we have dogs and horses, from birds we have eagls and ducks and from fishes we have swordfishes.

![UML](lab06-OOP.drawio.png)

In Dog class :

- I overrde 4 abstract methods
- I override 2 virtual methods
- I override 2 virtual properties

In  Swordfish class

- I override two abstract properties

In Program class 

- I used polymorphism (Dog husky = new SiberianHusky();)


## lab 7


I added two interfaces IAdopt and Iadoptable.


### IAdopt has the following:


  string application
        {
            set; get;
        }

        int AgeRequirements
        {
            set; get;
        }

        int ApotionFee
        {
            set; get;
        }

        string HomeVisit();


### Iadoptable has the following:


        Boolean friendly
        {
            set; get;
        }

        Boolean goodWithKids
        {
            set; get;
        }

## tests
I created three Xunit tests:

- InterfaceImplementation()

- Inheritance()

- Ploymorphism()




