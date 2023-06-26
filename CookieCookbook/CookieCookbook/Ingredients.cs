using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookbook
{
    abstract class Ingredients
    {
        public abstract int ID { get; }
        public abstract string Name { get; set; }

        public abstract void PreparationInstructions();
    }
}
