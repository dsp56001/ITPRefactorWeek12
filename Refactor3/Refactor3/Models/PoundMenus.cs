using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    static class PoundMenus
    {
        public static Menu PoundSelectDog = new Menu()
        {
            Text = "Would you like to select a pet?",
            MenuChoices = new List<String>() { "Yes", "No" }
        };

        public static Menu PoundMenu = new Menu()
        {
            Text = "Select an option?",
            MenuChoices = new List<String>() { "Get all pet details", "Bark all dogs", "Select a dog", "Dog Details", "Quit" }
        };

        public static Menu PoundBarkAllAdogs = new Menu()
        {
            Text = "Would you like to bark all the dogs?",
            MenuChoices = new List<String>() { "Yes", "No" }
        };

        public static Menu PoundGetDogDetails = new Menu()
        {
            Text = "Would you like to get all the dog details?",
            MenuChoices = new List<String>() { "Yes", "No" }
        };


    }
}
