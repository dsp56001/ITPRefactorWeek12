using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Menu
    {
        public string Text;
        public List<String> MenuChoices;

        int selectedIndex;
        string selectedChoice;

        public Menu()
        {
            this.Text = "Sample Menu";
            MenuChoices = new List<string>() { "Ok", "Cancel" };
        }
        public string ShowMenu()
        {
            Console.Clear();
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
