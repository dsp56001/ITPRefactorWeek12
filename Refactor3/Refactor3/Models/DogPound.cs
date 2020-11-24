using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class DogPound
    {
        List<Dog> Dogs;

        public DogPound()
        {
            Dogs = new List<Dog>();
        }

        public void SetupDogs()
        {
            //Make three dogs
            Dogs = new List<Dog>() {
            new Dog() { Name = "dog1", Age = 1, Weight = 1, BarkSound = "woof!" },
            new Dog() { Name = "dog2", Age = 2, Weight = 2, BarkSound = "arf!" },
            new Dog() { Name = "dog3", Age = 3, Weight = 3, BarkSound = "bowow!" }
            };
        }

        public Dog SelectADog()
        {
            Dog selectedDog = Dogs[0];
            Console.WriteLine("Please Choose a Dog:");
            string dogsMenu = "";
            foreach (Dog d in Dogs)
            {
                dogsMenu += $"\n{Dogs.IndexOf(d)+1} \t {d.Name}";
            }
            Console.WriteLine(dogsMenu);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            try
            {
                int selectedIndex = int.Parse(key.KeyChar.ToString());
                selectedDog = Dogs[selectedIndex-1];
            }
            catch
            {
                Console.WriteLine("Can't Select that dog");
            }
            return selectedDog;
        }

        internal void BarkAllDogs()
        {

            foreach (Dog dog in Dogs)
            {
                Console.Write(dog.Bark() + "\t");
            }
        }

        public void AboutAllDogs()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine(dog.About() + "\n");
            }
        }
    }
}
