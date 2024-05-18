namespace Lesson6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regular rectangle:");
            RectangleCreation rectangle1 = new RectangleCreation(5.63, 8);
            rectangle1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Increasing rectangle size:");
            rectangle1.ChangeSize(10, 85.41);
            rectangle1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Doubling the length and width:");
            rectangle1.IncreaseSize();
            rectangle1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle with length of 0:");
            RectangleCreation rectangle2 = new RectangleCreation(0, 8);
            rectangle2.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Regular square:");
            RectangleCreation square1 = new RectangleCreation(5);
            square1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Increasing square size:");
            square1.ChangeSize(20);
            square1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Square with negative side length:");
            RectangleCreation square2 = new RectangleCreation(-8.5);
            square2.PrintRectangleInfo();
            Console.WriteLine();
        }
    }
}
