namespace _16.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine() ?? "abc";
            int vowelCount = CountVowels(text);
            Console.WriteLine($"{vowelCount}");
        }

        static int CountVowels(string text)
        {
            int count = 0;
            string vowels = "AEIOUaeiou";

            foreach (char character in text)
            {
                if (vowels.Contains(character))
                {
                    count++;
                }
            }

            return count;
        }
    }
}