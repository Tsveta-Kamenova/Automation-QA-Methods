using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace _06.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseInput = int.Parse(Console.ReadLine() ?? "1");
            int powerInput = int.Parse(Console.ReadLine() ?? "1");

            Console.WriteLine(calculatePower(baseInput, powerInput));
        }
        static int calculatePower(int baseNumber, int powerNumber)
        {
            int result = 1;

            if (powerNumber != 0)
            {
                for (int i = 1; i <= powerNumber; i++)
                {
                    result = result * baseNumber;
                }
            }
            return result;
        }
    }
}