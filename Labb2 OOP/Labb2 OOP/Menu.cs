using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_OOP
{
    class Menu
    {

        public static void PrintMainMenu()
        {
            Runtime runtime = new Runtime();
            // test

            Console.Clear();
            Console.WriteLine("1. Add dog");
            Console.WriteLine("2. Add snake");
            Console.WriteLine("3. Add crow");
            Console.WriteLine("4. Remove dog");
            Console.WriteLine("5. Remove snake");
            Console.WriteLine("6. Remove crow");
            Console.WriteLine("7. Show all dogs");
            Console.WriteLine("8. Show all snakes");
            Console.WriteLine("9. Show all crows");
            Console.WriteLine("0. Exit");

            Console.Write("Choice: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    runtime.addDog();
                    PrintMainMenu();
                    break;

                case 2:
                    runtime.addSnake();
                    PrintMainMenu();
                    break;

                case 3:
                    runtime.addCrow();
                    PrintMainMenu();
                    break;

                case 4:
                    runtime.RemoveDog();
                    PrintMainMenu();
                    break;

                case 5:
                    runtime.RemoveSnake();
                    PrintMainMenu();
                    break;

                case 6:
                    runtime.RemoveCrow();
                    PrintMainMenu();
                    break;

                case 7:
                    foreach (var Item in runtime.allDogs)
                    {
                        Console.WriteLine(Item.Information());
                    }
                    PrintMainMenu();
                    break;

                case 8:
                    foreach (var Item in runtime.allSnakes)
                    {
                        Console.WriteLine(Item.Information());
                    }
                    PrintMainMenu();
                    break;

                case 9:
                    foreach (var Item in runtime.allCrows)
                    {
                        Console.WriteLine(Item.Information());
                    }
                    PrintMainMenu();
                    break;

                case 0:
                    Console.WriteLine("Bye bye");
                    break;
            }
        }
    }
}
