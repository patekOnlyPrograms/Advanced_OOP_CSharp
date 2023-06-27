using System;
using CookieCookbook;

namespace Ingredients
{

    public class WheatFlour : IngredientsBuilder
    {
        public  string Name => "Wheat Flour";
        public string PrepInstructions => "Sieve. Add to other ingredients.";
    }

    public class CoconutFlour : IngredientsBuilder
    {
        public  string Name => "Coconut Flour";
        public string PrepInstructions => "Sieve. Add to other ingredients.";
    }

    public class Butter : IngredientsBuilder
    {
        public  string Name => "Butter";
        public string PrepInstructions => "Melt on low heat. Add to other ingredients.";

    }

    public class Chocolate : IngredientsBuilder{
        public  string Name => "Chocolate";
        public string PrepInstructions => "Melt in a water heat. Add to other ingredients.";
    }

    public class Sugar : IngredientsBuilder{
        public  string Name => "Sugar";
        public string PrepInstructions => "Add to other ingredients.";
    }

    public class Cardamom : IngredientsBuilder{
        public  string Name => "Cardamom";
        public string PrepInstructions => "Take half a teaspoon. Add to other ingredients.";

    }

    public class Cinnamon : IngredientsBuilder{
        public  string Name => "Cinnamon";
        public string PrepInstructions => "Take half a teaspoon. Add to other ingredients.";
    }

    public class CocoaPowder : IngredientsBuilder{
        public  string Name => "CocoaPowder";
        public string PrepInstructions => "Add to other ingredients.";
    }

    
}