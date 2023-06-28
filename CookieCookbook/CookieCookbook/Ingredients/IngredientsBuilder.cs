namespace CookieCookbook.IngredientsNS
{
    public abstract class IngredientsBuilder
    {
        public abstract int ID { get; }
        public abstract string Name { get; }
        public abstract string PreparationInstructions { get; }
    }
}