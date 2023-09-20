namespace NumbersSumCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {1,4,6,7,8,-1,20,18};
            bool positiveOnly = true;
            int sum;
            if (positiveOnly)
            {
                sum = new PositiveNumbersSumCalculator().Calulate(numbers);
            }
            else
            {
                sum = new NumbersSumCalculator().Calulate(numbers);
            }
            
            Console.WriteLine("Sum is " + sum);
        }
    }

    public class NumbersSumCalculator
    {

        public int Calulate(List<int> numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (ShallBeAdded(item))
                {
                    sum += item;
                }
                
            }
            return sum;
        }

        protected  virtual bool ShallBeAdded (int number)
        {
            return true;
        }
    }

    public class PositiveNumbersSumCalculator : NumbersSumCalculator
    {

        protected override bool ShallBeAdded(int number)
        {
            return number > 0;
        }
    }
}