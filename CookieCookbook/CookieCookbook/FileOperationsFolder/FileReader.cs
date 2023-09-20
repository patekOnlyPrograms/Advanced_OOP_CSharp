namespace CookieCookbook.FileOperationsFolder;

public class FileReader
{
    public string fileName { get; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recipes.txt");
    
    public string ReadFromTxtFileAndShowItems()
    {
        var allItemsInList = 
        //return "****" + $"{File.ReadLines(fileName).ToList()}" + "****";
    }
}