using CookieCookbook.IngredientsNS;

namespace CookieCookbook.Ingredients
{
    public class IngredientsVault : InterfaceIngredients
    {
        public IEnumerable<IngredientsBuilder> Ingredients { get; } = new List<IngredientsBuilder>
        {
            new WheatFlour(),
              new CoconutFlour(),
              new Butter(),
              new Chocolate(),
              new Sugar(),
              new Cardamom(),
              new Cinnamon(),
              new CocoaPowder()
        };

        public void printAllIngredients()
        {
            foreach(var item in Ingredients)
            {
                Console.WriteLine("{0,-10} {1,0}", item.ID,item.Name);
            }
        }

        public IngredientsBuilder getID(int id)
        {
            foreach (var item in Ingredients)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
