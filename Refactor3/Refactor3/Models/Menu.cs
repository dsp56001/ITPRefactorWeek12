using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// Console Menu 
    /// Shows a menu with choices returns the users choice in the form of a string
    /// </summary>
    class Menu
    {
        public string Text;                 //Text to display in meni
        public List<String> MenuChoices;    //Menu options

        int selectedIndex;                  //index users selected as an int
        string selectedChoice;              //selected string

        public Menu()
        {
            this.Text = "Sample Menu";
            MenuChoices = new List<string>() { "Ok", "Cancel" };
        }
        public string ShowMenu()
        {
            //May add an option to clear screen
            //Console.Clear();                //Not sure if we shoudl clear the screen on every menu
            Console.WriteLine(this.Text);
            Console.WriteLine(ShowOptions());
            this.selectedIndex = GetChoiceIndex();
            this.selectedChoice = GetOptionFromIndex(this.selectedIndex);
            return this.selectedChoice;
        }

        private string GetOptionFromIndex(int index)
        {
            return this.MenuChoices[index];
        }

        int indexChoice = 0;
        private int GetChoiceIndex()
        {
            string choice = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine(); //add a space
            try
            {
                indexChoice = int.Parse(choice);
                indexChoice--;
                string test = this.MenuChoices[indexChoice];
            }
            catch
            {
                Console.WriteLine("not an option please try again.");
                this.GetChoiceIndex();
            }
            return indexChoice;
        }
        public string ShowOptions()
        {
            string strOptions = string.Empty;
            foreach (var option in this.MenuChoices)
            {
                strOptions += this.MenuChoices.IndexOf(option) + 1 + " " + option + "\n";
            }
            return strOptions;
        }


    }
}
