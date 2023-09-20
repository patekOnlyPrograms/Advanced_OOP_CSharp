
using UserInteractionsNS;
using CookieCookbook.FileOperationsFolder;

namespace CookieCookbook
{
    public class Program
    {

        
        static void Main(string[] args)
        {
            fileOps fo = new fileOps();
            fo.createTxtFile(); 
            FileReader fileReader = new FileReader();
            UserInteractions us = new UserInteractions();
            Console.WriteLine(fileReader.ReadFromTxtFileAndShowItems());
            us.StarterMessage();
            us.UserInput();
        }
    }
}