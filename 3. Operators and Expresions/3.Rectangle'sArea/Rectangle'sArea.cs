using System;
    class RectanglesArea
    {
        static void Main()
        {
            Console.Write("Enter a value for the rectangle's width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for the rectangle's height: ");
            double height = double.Parse(Console.ReadLine());
            double area = (height * width)/2;
            Console.WriteLine("The rectangle's area is {0}.", area);
        }
 }
