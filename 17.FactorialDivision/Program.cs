namespace _17.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine() ?? "2");
            int secondNumber = int.Parse(Console.ReadLine() ?? "2");

            double currentFactorialFirst = CalculateFactorial(firstNumber);
            double currentFactorialSecond = CalculateFactorial(secondNumber);

            double resultToPrint = currentFactorialFirst / currentFactorialSecond;
            Console.WriteLine(resultToPrint);
        }

        static double CalculateFactorial(double number)
        {
            double result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}