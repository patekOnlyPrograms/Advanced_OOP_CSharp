using CookieCookbook.IngredientsNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookbook.Ingredients
{
    public interface InterfaceIngredients
    {
        IEnumerable<IngredientsBuilder> Ingredients { get; }

        IngredientsBuilder getID(int id);
    }
}
