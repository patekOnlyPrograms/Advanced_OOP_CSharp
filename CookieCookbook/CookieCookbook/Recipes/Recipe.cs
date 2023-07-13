using CookieCookbook.IngredientsNS;

namespace CookieCookbook.Recipes
{
    public class Recipe
    {
        public IEnumerable<IngredientsBuilder> Ingredients { get; }

        public Recipe(IEnumerable<IngredientsBuilder> ingredients)
        {
            Ingredients = ingredients;
        }
        
        //public 
    }
}


