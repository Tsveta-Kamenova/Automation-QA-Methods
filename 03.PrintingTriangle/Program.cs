namespace _03.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static void PrintLine(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            static void PrintTriangle(int n)
            {
                for (int line = 1; line <= n; line++)
                    PrintLine(1, line);

                for (int line = n - 1; line >= 1; line--)
                    PrintLine(1, line);
            }

            int number = int.Parse(Console.ReadLine() ?? "5");
            PrintTriangle(number);
        }
    }
}