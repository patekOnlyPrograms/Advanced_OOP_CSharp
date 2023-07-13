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
                    byte[] title = new UTF8Encoding(true).GetBytes("Recipes");
                    fs.Write(title, 0, title.Length);
                }
                Console.WriteLine("File created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //not quite sure why to use linq
        // public void addIngredientsToFile(IEnumerable<int> Ingredients)
        // {
        //     try
        //     {
        //         IEnumerable<string> strings = Ingredients.Select(n => n.ToString());
        //         File.WriteAllText(fileName, strings);
        //     }
        //     catch
        //     {
        //         
        //     }
        // }
        
        
    }
}