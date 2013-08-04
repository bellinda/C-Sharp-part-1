using System;
    class TrapezoidsArea
    {
        static void Main()
        {
            Console.WriteLine("How long is the side a of the trapezoid?");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("How long ist the side bof the trapezoid?");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("How long ist the hight h of the trapezoid?");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) * h) / 2;
            Console.WriteLine("The area of the trapezoid is = {0}.", area);
        }
    }
