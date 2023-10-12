using System.Diagnostics;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void signOfIntegerNumbers(int grade)
            {

                if (grade > 0 )
                    Console.WriteLine("The number {0} is positive.",grade);
                else if (grade < 0)
                    Console.WriteLine("The number {0} is negative.", grade);
                else
                    Console.WriteLine("The number {0} is zero.", grade);
            }

            int grade = int.Parse(Console.ReadLine() ?? "5");
            signOfIntegerNumbers(grade);
        }
    }
}