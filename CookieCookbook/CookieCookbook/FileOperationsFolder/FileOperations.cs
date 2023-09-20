using CookieCookbook.IngredientsNS;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Linq;

namespace CookieCookbook.FileOperationsFolder
{

    public class fileOps
    {
        public string fileName { get; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recipes.txt");
        public void createTxtFile()
        {
            
            try
            {
                if (File.Exists(fileName))
                {
                    Console.WriteLine("Will append new recipe");
                    return;
                }
                using (FileStream fs = File.Create(fileName))
                {
                    Console.WriteLine("File created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public void WriteToTxtFile(List<string> userInputRecipe)
        {
            string formattedList = "[" + string.Join(",", userInputRecipe) + "]" + Environment.NewLine;
            //IEnumerable<string> ingredients = formattedList.Select(n => n.ToString());
            File.AppendAllText(fileName, formattedList);
        }

        public void createJSONFile()
        {
            
        }
    }
}