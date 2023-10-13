namespace _09.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productInput = Console.ReadLine() ?? "water";
            int quantityInput = int.Parse(Console.ReadLine() ?? "1");

            Console.WriteLine($"{ordersPrices(productInput, quantityInput):f2}");
        }

        static double ordersPrices(string product, int quantity)
        {
            double price = 0.0;

            switch (product)
            {
                case "coffee":
                    price = 1.50 * quantity;
                    break;
                case "water":
                    price = 1.00 * quantity;
                    break;
                case "coke":
                    price = 1.40 * quantity;
                    break;
                case "snacks":
                    price = 2.00 * quantity;
                    break;
                default:
                    Console.WriteLine("Invalid data type.");
                    break;
            }
            return price;
        }
    }
}