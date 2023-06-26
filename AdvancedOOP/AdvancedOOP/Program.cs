namespace AdvancedOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*var pizza = new Pizza();
            pizza.AddIngredient(new Cheddar());
            pizza.AddIngredient(new Mozarella());
            pizza.AddIngredient(new TomatoSauce());
            Console.Write(pizza.Describe());*/

            /*Console.WriteLine("Variable of type Cheddar");
            Cheddar cheedar = new Cheddar();
            //Console.WriteLine(cheedar.PublicMethod());
            Console.WriteLine(cheedar.Name);
            Console.WriteLine("Variable of type Ingredient");
            Ingredient ingredient = new Cheddar();
            Console.WriteLine(ingredient.Name);
            //works because cheddar is an ingredient
            var ingredients = new List<Ingredient>
            {
                new Cheddar(),
                new TomatoSauce(),
                new Mozarella()
            };
            Console.WriteLine();
            foreach (Ingredient ingredientItem in ingredients)
            {
                Console.WriteLine(ingredientItem.Name);
            }*/
            //Upcasting - convert a derived to a base class
            Ingredient ingredient1 = new Cheddar();

            //Downcasting -Downcasting is where you take a base class and then try and turn it 
            //into a more specific class.
            Ingredient randomIngredient = GenerateRandomIngredient();
            /*Console.WriteLine("Random ingredient is");
            Cheddar cheddar = (Cheddar) randomIngredient;*/

            Ingredient GenerateRandomIngredient()
            {
                var random = new Random();
                var number = random.Next(1, 4);
                if (number == 1) { return new Cheddar(); }
                if (number == 2) { return new TomatoSauce(); }
                else return new Mozarella();
            }

            /*if (randomIngredient is Cheddar cheddar)
            {
                Console.WriteLine("cheddar object: " + cheddar);
            }*/
            Ingredient ingredient = GenerateRandomIngredient();
            Console.WriteLine("Ingredient is " + ingredient);
            Cheddar cheddar = ingredient as Cheddar;
            if(cheddar is not null)
            {
                Console.WriteLine(cheddar.Name);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            /*Ingredient nullIngredient = null;
            if (nullIngredient is not null)
            {
                Console.WriteLine(nullIngredient.Name);
            }*/
        }

        public class Pizza
        {
            private List<Ingredient> _ingredients = new List<Ingredient?>();
            public void AddIngredient(Ingredient ingredients) => _ingredients.Add(ingredients);

            public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
        }

        public class Ingredient
        {

            public virtual string Name { get; } = "Some Ingredient";
            public int PublicField;

            public string PublicMethod() => "This method is public";
            protected string ProtectedMethod() => "This method is protected";
            private string PrivateMethod() => "This method is priate";
        }


        public class Cheddar : Ingredient
        {
            public override string Name => "Cheddar cheese";
            public int AgedForMonths { get; }

            public void UseMethodFromBaseClass()
            {
                Console.WriteLine(PublicMethod());
                Console.WriteLine(ProtectedMethod());
            }
        }

        public class TomatoSauce : Ingredient
        {
            public override string Name => "Tomato sauce";
            public int TomatoIn100Grams { get; }

        }

        public class Mozarella : Ingredient
        {
            public override string Name => "Mozarella";
            public bool IsLight { get; }
        }
    }
}