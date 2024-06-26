﻿namespace Lesson6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regular rectangle 5.63 x 8:");
            Rectangle rectangle1 = new Rectangle(5.63, 8);
            rectangle1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Increasing rectangle size by 10 and 85.41:");
            rectangle1.ChangeSize(10, 85.41);
            rectangle1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Doubling the length and width:");
            rectangle1.IncreaseSize();
            rectangle1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle 0 x 8:");
            Rectangle rectangle2 = new Rectangle(0, 8);
            rectangle2.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Regular square 5 x 5:");
            Rectangle square1 = new Rectangle(5);
            square1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Increasing square side size by 20:");
            square1.ChangeSize(20);
            square1.PrintRectangleInfo();
            Console.WriteLine();

            Console.WriteLine("Square -8.5 x -8.5:");
            Rectangle square2 = new Rectangle(-8.5);
            square2.PrintRectangleInfo();
            Console.WriteLine();
        }
    }
}
