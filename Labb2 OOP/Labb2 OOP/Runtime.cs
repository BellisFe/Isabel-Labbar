using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.NullReferenceException;


namespace Labb2_OOP
{
    class Runtime
    {
        public List<Dog> allDogs { get; set; }
        public List<Snake> allSnakes { get; set; }
        public List<Crow> allCrows { get; set; }

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

            
            allDogs = new List<Dog>()
            {
                myDog1,
                myDog2

            };

            allSnakes = new List<Snake>()
            {
                mySnake1,
                mySnake2
            };

            allCrows = new List<Crow>()
            {
                myCrow1,
                myCrow2
            };

            Menu.PrintMainMenu();

        }


        public void addDog ()
        {
            Dog newDog = new Dog();

            Console.Write("Breed: ");
            newDog.Breed = Console.ReadLine();

            Console.Write("Sound: ");
            newDog.Sound = Console.ReadLine();

            Console.Write("Age: ");
            newDog.Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newDog.Weight = Console.ReadLine();

            Console.Write("Way of moving: ");
            newDog.CanRun = Console.ReadLine();

            Console.Write("Diet: ");
            newDog.Diet = Console.ReadLine();

            Console.Write("Free time activity: ");
            newDog.FreeTime = Console.ReadLine();



            allDogs.Add(newDog);


        }

        public void addSnake()
        {
            Snake newSnake = new Snake();

            Console.Write("Breed: ");
            newSnake.Breed = Console.ReadLine();

            Console.Write("Sound: ");
            newSnake.Sound = Console.ReadLine();

            Console.Write("Age: ");
            newSnake.Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newSnake.Weight = Console.ReadLine();

            Console.Write("Non poisonus or poisonus: ");
            newSnake.Poisonous = Console.ReadLine();

            Console.Write("Diet: ");
            newSnake.Diet = Console.ReadLine();

            Console.Write("Free time activity: ");
            newSnake.FreeTime = Console.ReadLine();



            allSnakes.Add(newSnake);


        }

        public void addCrow()
        {
            Crow newCrow = new Crow();

            Console.Write("Breed: ");
            newCrow.Breed = Console.ReadLine();

            Console.Write("Sound: ");
            newCrow.Sound = Console.ReadLine();

            Console.Write("Age: ");
            newCrow.Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newCrow.Weight = Console.ReadLine();

            Console.Write("Lenght of wings: ");
            newCrow.LenghtOfWings = int.Parse(Console.ReadLine());

            Console.Write("Diet: ");
            newCrow.Diet = Console.ReadLine();

            Console.Write("Free time activity: ");
            newCrow.FreeTime = Console.ReadLine();


            allCrows.Add(newCrow);

        }

        public void RemoveDog()
        {
            for (int i = 1; i <= allDogs.Count; i++)
            {
                Console.WriteLine( allDogs);
            }

            Console.Write("Choice: ");
            int index = int.Parse(Console.ReadLine());

            allDogs.RemoveAt(index - 1);
        }

        public void RemoveSnake()
        {
            for (int i = 1; i <= allSnakes.Count; i++)
            {
                Console.WriteLine(allSnakes);
            }

            Console.Write("Choice: ");
            int index = int.Parse(Console.ReadLine());

            allSnakes.RemoveAt(index - 1);
        }

        public void RemoveCrow()
        {
            for (int i = 1; i <= allCrows.Count; i++)
            {
                Console.WriteLine(allCrows);
            }

            Console.Write("Choice: ");
            int index = int.Parse(Console.ReadLine());

            allCrows.RemoveAt(index - 1);
        }
    }
}
