using System;
    class GreatestOf5
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine()); 
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > f)
            {
                Console.WriteLine("{0} is the greatest variable.", a);
            }
            else if (b > a && b > c && b > d && b > f)
            {
                Console.WriteLine("{0} is the greatest variable.", b);
            }
            else if (c > a && c > b && c > d && c > f)
            {
                Console.WriteLine("{0} is the greatest variable.", c);
            }
            else if (d > a && d > b && d > c && d > f)
            {
                Console.WriteLine("{0} is the greatest variable.", d);
            }
            else
            {
                Console.WriteLine("{0} is the greatest variable.", f);
            }
        }
    }

