using System;
using CookieCookbook.FileOperationsFolder;
using CookieCookbook.Ingredients;

namespace UserInteractionsNS
{
    public class UserInteractions
    {
        private fileOps _fileOps = new fileOps();
        public void StarterMessage(){
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            Console.WriteLine("Printing available ingredients");
            IngredientsVault rs = new IngredientsVault();
            rs.printAllIngredients();
        }

        public void UserInput()
        {
            List<string> userInputRecipe = new List<string>();
            Console.WriteLine("Selecting ingredients for a new recipe.");
            
            string userSelection;
            bool selectionFinished = false;
            while (selectionFinished == false) 
            {
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
                userSelection = Console.ReadLine();
                if (int.TryParse(userSelection, out int number1))
                {
                    if(number1 > 0  && number1 <= new IngredientsVault().Ingredients.Count())
                    {
                        Console.WriteLine("Recipe added");
                        userInputRecipe.Add(userSelection);
                        
                    }
                    else
                    {
                        Console.WriteLine("Ingredient is not in the above list");
                    }
                }
                else
                {
                    Console.WriteLine("No ingredients have been selected. Recipe will not be saved." + 
                                      "Or the ingredients have been selected and now you want to save");
                    selectionFinished = true;
                }
            }
            _fileOps.WriteToTxtFile(userInputRecipe);
        }
    }
}