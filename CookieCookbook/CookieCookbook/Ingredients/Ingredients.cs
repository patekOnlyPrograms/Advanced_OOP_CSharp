using System;
using CookieCookbook.IngredientsNS;

namespace CookieCookbook.Ingredients
{
    class WheatFlour : IngredientsBuilder
    {
        public override int ID => 1;

        public override string Name => "Wheat flour";

        public override string PreparationInstructions => "Sieve. Add to other ingredients";
    }

    class CoconutFlour : IngredientsBuilder
    {
        public override int ID => 2;
        public override string Name => "Coconut Flour";
        public override string PreparationInstructions => "Sieve. Add to other ingredients.";
    }

    class Butter : IngredientsBuilder
    {
        public override int ID => 3;
        public override string Name => "Butter";
        public override string PreparationInstructions => "Melt on low heat. Add to other ingredients.";
    }

    class Chocolate : IngredientsBuilder
    {
        public override int ID => 4;
        public override string Name => "Chocolate";
        public override string PreparationInstructions => "Melt in a water heat. Add to other ingredients.";
    }

    class Sugar : IngredientsBuilder
    {
        public override int ID => 5;
        public override string Name => "Sugar";
        public override string PreparationInstructions => "Add to other ingredients.";
    }

    class Cardamom : IngredientsBuilder
    {
        public override int ID => 6;
        public override string Name => "Cardamom";
        public override string PreparationInstructions => "Take half a teaspoon. Add to other ingredients.";

    }

    class Cinnamon : IngredientsBuilder
    {
        public override int ID => 7;
        public override string Name => "Cinnamon";
        public override string PreparationInstructions => "Take half a teaspoon. Add to other ingredients.";
    }

    class CocoaPowder : IngredientsBuilder
    {
        public override int ID => 8;
        public override string Name => "CocoaPowder";
        public override string PreparationInstructions => "Add to other ingredients.";
    }
}