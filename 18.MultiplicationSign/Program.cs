namespace _18.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine() ?? "1");
            int num2 = int.Parse(Console.ReadLine() ?? "1");
            int num3 = int.Parse(Console.ReadLine() ?? "1");

            string result = MultiplicationSign(num1, num2, num3);
            Console.WriteLine(result);
        }

        static string MultiplicationSign(int n1, int n2, int n3)
        {
            if (n1 == 0 || n2 == 0 || n3 == 0)
                return "zero";
            else if ((n1 > 0 && n2 > 0 && n3 > 0) || (n1 < 0 && n2 < 0 && n3 > 0) || (n1 < 0 && n2 > 0 && n3 < 0) || (n1 > 0 && n2 < 0 && n3 < 0))
                return "positive";
            else return "negative";
            //else if (n1 < 0 ^ n2 < 0 ^ n3 < 0)
            //    return "negative";
            //else
            //    return "positive";
        }
    }
}