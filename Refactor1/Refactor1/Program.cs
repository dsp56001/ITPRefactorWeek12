using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make three dogs
            Dog dog1 = new Dog() { Name = "dog1", Age = 1, Weight = 1, BarkSound="woof!" };
            Dog dog2 = new Dog() { Name = "dog2", Age = 2, Weight = 2, BarkSound="arf!" };
            Dog dog3 = new Dog() { Name = "dog3", Age = 3, Weight = 3, BarkSound="bowow!" };

            //Ask which dog to bark
            Console.WriteLine("Which dog would you like to bark?");
            Console.WriteLine("1 for " + dog1.Name);
            Console.WriteLine("2 for " + dog2.Name);
            Console.WriteLine("3 for " + dog3.Name);

            //Get response
            string response = Console.ReadLine();
            int dogPick = int.Parse(response);

            //Check response
            if(dogPick == 1)
            {
                string bark = dog1.Bark();
                Console.WriteLine(bark);
            }
            if(dogPick == 2)
            {
                string bark = dog1.Bark();
                Console.WriteLine(bark);
            }
            if(dogPick == 3)
            {
                string bark = dog1.Bark();
                Console.WriteLine(bark);
            }

            Console.WriteLine("Thank you for barking the dog.");
            Console.ReadKey();
        }
    }
}
