
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
            UserInteractions us = new UserInteractions();
            us.StarterMessage();
            us.UserInput();
        }
    }
}