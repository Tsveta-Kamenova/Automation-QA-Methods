namespace _08.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInput = Math.Abs(int.Parse(Console.ReadLine() ?? "1"));
            Console.WriteLine(evensByOdds(numberInput));
        }
        static int evensByOdds(int number)
        {
            int sumEvens = 0;
            int sumOdds = 0;

            for (int currentNumber = number; currentNumber > 0; currentNumber /= 10)
            {
                int digit = currentNumber % 10;
                if (digit % 2 == 0)
                    sumEvens += digit;
                else
                    sumOdds += digit;
            }
            int result = sumEvens * sumOdds;
            return result;
        }
    }
}
