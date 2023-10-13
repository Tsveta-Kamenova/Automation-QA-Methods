namespace _07.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
            {
                string dataType = Console.ReadLine();

                switch (dataType)
                {
                    case "int":
                        int int1 = int.Parse(Console.ReadLine());
                        int int2 = int.Parse(Console.ReadLine());
                        int maxInt = CompareValues(int1, int2);
                        Console.WriteLine($"{maxInt}");
                        break;

                    case "char":
                        char char1 = char.Parse(Console.ReadLine());
                        char char2 = char.Parse(Console.ReadLine());
                        char maxChar = CompareValues(char1, char2);
                        Console.WriteLine($"{maxChar}");
                        break;

                    case "string":
                        string str1 = Console.ReadLine();
                        string str2 = Console.ReadLine();
                        string maxString = CompareValues(str1, str2);
                        Console.WriteLine($"{maxString}");
                        break;

                    default:
                        Console.WriteLine("Invalid data type.");
                        break;
                }
            }

            // Method to compare and return the biggest integer
            static int CompareValues(int a, int b)
            {
                return Math.Max(a, b);
            }

            // Method to compare and return the biggest character
            static char CompareValues(char a, char b)
            {
                return (a > b) ? a : b;
            }

            // Method to compare and return the biggest string
            static string CompareValues(string a, string b)
            {
                return string.Compare(a, b) > 0 ? a : b;
            }
        }
    }
