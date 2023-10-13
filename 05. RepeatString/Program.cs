namespace _05._RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine () ?? "a";
            int userRepetition = int.Parse (Console.ReadLine () ?? "1");

            repeatString (userInput, userRepetition);
        }
        static void repeatString(string inputString, int countRepetition)
        {
            for (int i = 0; i < countRepetition; i++)
            {
                Console.Write(inputString);
            }
        }

    }
}