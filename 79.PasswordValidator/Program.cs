namespace _79.PasswordValidator
{ 
    internal class Program
    {
    static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (IsPasswordValid(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPasswordValid(string password)
        {
            bool isValid = true;

            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (!ContainsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (CountDigits(password) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            return isValid;
        }

        static bool ContainsOnlyLettersAndDigits(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static int CountDigits(string str)
        {
            int digitCount = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }
            return digitCount;
        }
    }
}
