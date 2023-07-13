using System;
using CookieCookbook.FileOperationsFolder;
using CookieCookbook.Ingredients;

namespace UserInteractionsNS
{
    public class UserInteractions
    {
        public void StarterMessage(){
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            Console.WriteLine("Printing available ingredients");
            IngredientsVault rs = new IngredientsVault();
            rs.printAllIngredients();
        }

        public void UserInput()
        {
            Console.WriteLine("Selecting ingredients for a new recipe.");
            
            string userSelection;
            bool selectionFinished = false;
            while (selectionFinished == false) 
            {
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
                userSelection = Console.ReadLine();
                if (int.TryParse(userSelection, out int number1))
                {
                    if(number1 > 0)
                    {
                        Console.WriteLine("Recipe added");
                    }
                }
                else
                {
                    Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
                }
            }

        }
    }
}