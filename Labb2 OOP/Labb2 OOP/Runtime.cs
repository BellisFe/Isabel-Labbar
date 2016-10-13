using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_OOP
{
    class Runtime
    {
        public void Start()
        {


            Dog myDog1 = new Dog
            {
                Age = 2,
                Weight = "4kg",
                Sound = "ruff",
                CanRun = "pounce",
                Breed = "mix",
                Diet = "Cheese",
                FreeTime = "play"
            };

            Dog myDog2 = new Dog
            {
                Age = 8,
                Weight = "6kg",
                Sound = "woof wooof",
                CanRun = "stroll",
                Breed = "griffon",
                Diet = "dog food",
                FreeTime = "guard master"
            };

            Snake mySnake1 = new Snake
            {
                Age = 5,
                Weight = "10kg",
                Sound = "pthhhh",
                Poisonous = "not poisinous",
                Breed = "boa",
                Diet = "mice",
                FreeTime = "rest in shade"
            };

            Snake mySnake2 = new Snake
            {
                Age = 3,
                Weight = "7kg",
                Sound = "chkchkchk",
                Poisonous = "poisonous",
                Breed = "rattlesnake",
                Diet = "mice",
                FreeTime = "stalk prey"
            };

            Crow myCrow1 = new Crow
            {
                Age = 4,
                Weight = "1,2kg",
                Sound = "craa craa",
                Breed = "carrion crow",
                LenghtOfWings = 85,
                Diet = "eathworms",
                FreeTime = "soar the sky"
            };

            Crow myCrow2 = new Crow
            {
                Age = 6,
                Weight = "2kg",
                Sound = "caaaw caaw",
                Breed = "northwestern crow",
                LenghtOfWings = 90,
                Diet = "stranded fish",
                FreeTime = "look for food"
            };

            Console.WriteLine(myDog1.Information());
            Console.WriteLine(myDog2.Information());
            Console.WriteLine(mySnake1.Information());
            Console.WriteLine(mySnake2.Information());
            Console.WriteLine(myCrow1.Information());
            Console.WriteLine(myCrow2.Information());

            List<Dog> allDogs = new List<Dog>()
            {
                new Dog {Breed = "Yorkie", },
                new Dog {}
                
            };

        }
    }
}
