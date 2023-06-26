namespace NumericTransformation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Exercise
    {
        public static int Transform(
            int number)
        {
            var transformations = new List<INumericTransformation>
            {
                new By1Incrementer(),
                new By2Multiplier(),
                new ToPowerOf2Raiser()
            };

            var result = number;
            foreach (var transformation in transformations)
            {
                result = transformation.Transform(result);
            }
            return result;
        }
    }

    public class ToPowerOf2Raiser : INumericTransformation
    {
        public int Transform(int number) => (int) Math.Pow(number,2);
    }

    public class By2Multiplier : INumericTransformation
    {
        public int Transform(int number) => number * 2;
    }

    public class By1Incrementer : INumericTransformation
    {
        public int Transform(int number) => number + 1;
    }

    interface INumericTransformation
    {
        int Transform(int number);

    }
}