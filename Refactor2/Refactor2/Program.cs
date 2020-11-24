using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor2
{
    class Program
    {
        //Make three dogs
        static Dog dog1 = new Dog() { Name = "dog1", Age = 1, Weight = 1, BarkSound = "woof!" };
        static Dog dog2 = new Dog() { Name = "dog2", Age = 2, Weight = 2, BarkSound = "arf!" };
        static Dog dog3 = new Dog() { Name = "dog3", Age = 3, Weight = 3, BarkSound = "bowow!" };


        static void Main(string[] args)
        {
            
            //Adopt a dog

            //Ask which dog to bark
            Console.WriteLine("Which dog would you like to know more about?");
            Console.WriteLine("1 for " + dog1.Name);
            Console.WriteLine("2 for " + dog2.Name);
            Console.WriteLine("3 for " + dog3.Name);

            //Get Dog about response
            string response = Console.ReadLine();
            int dogPick = int.Parse(response);

            switch(dogPick)
            {
                case 1:
                    ShowDog1();
                    break;
                case 2:
                    ShowDog2();
                    break;
                default:
                    ShowDog3();
                    break;
            }

            Console.WriteLine("Would you like to know about another dog2?");
            string response2 = Console.ReadLine();

            switch(response2)
            {
                case "y":
                case "Y":
                case "yes":
                case "Yes":
                case "YES":
                    //Ask which dog to bark
                    Console.WriteLine("Which dog would you like to know more about?");
                    Console.WriteLine("1 for " + dog1.Name);
                    Console.WriteLine("2 for " + dog2.Name);
                    Console.WriteLine("3 for " + dog3.Name);

                    //Get Dog about response
                    string response3 = Console.ReadLine();
                    int dogPick2 = int.Parse(response3);

                    switch (dogPick2)
                    {
                        case 1:
                            ShowDog1();
                            break;
                        case 2:
                            ShowDog2();
                            break;
                        default:
                            ShowDog3();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("OK Bye") ;
                    break;
            }
        }

        public static void ShowDog1()
        {
            Console.WriteLine(dog1.About());
        }
        public static void ShowDog2()
        {
            Console.WriteLine(dog2.About());
        }
        public static void ShowDog3()
        {
            Console.WriteLine(dog2.About());
        }
    }
}
