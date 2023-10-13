using System.Drawing;

namespace _04.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widthInput = int.Parse(Console.ReadLine() ?? "1");
            int heightInput = int.Parse(Console.ReadLine() ?? "1");

            int area = CalculateRectangleArea(widthInput,heightInput);
            Console.WriteLine(area);
        }
        static int CalculateRectangleArea(int width, int height)
        {
            int rectangleArea = width * height;
            return rectangleArea;
        }
    }
}