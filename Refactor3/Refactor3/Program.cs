using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor3
{
    class Program
    {
        static void Main(string[] args)
        {
            DogPound pound = new DogPound();
            pound.SetupDogs();

            Dog myDog = new Dog();

            while (PoundMenus.PoundSelectDog.ShowMenu() == "Yes")
            {
                myDog = pound.SelectADog();
                Console.WriteLine($"You selected {myDog.About()}");
            }

            string choice = "";
            while (choice != "Quit")
            {
                choice = PoundMenus.PoundMenu.ShowMenu();
                switch (choice)
                {
                    case "Get all pet details":
                        pound.AboutAllDogs();
                        Console.ReadKey();
                        break;
                    case "Bark all dogs":
                        pound.BarkAllDogs();
                        Console.ReadKey();
                        break;
                    case "Select a dog":
                        myDog = pound.SelectADog();
                        Console.ReadKey();
                        break;
                    case "Dog Details":
                        Console.WriteLine(myDog.About());
                        Console.ReadKey(); 
                        break;
                }
                
            }
    }
    }
}
