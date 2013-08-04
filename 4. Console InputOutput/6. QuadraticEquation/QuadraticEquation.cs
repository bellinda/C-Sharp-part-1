using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double D, x1,x2,x;
        if (a != 0 && b != 0 && c != 0)
        {
            D = (b * b) - (4 * a * c);
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0} and x2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                x = x1 = x2 = (-b) / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
        if (a == 0)
        {
            x = (-c) / b;
            Console.WriteLine("Only one real root -> x = {0}.", x);
        }
        if (b == 0)
        {
            double m;
            m = (-c) / a;
            if (m >= 0)
            {
                x = Math.Sqrt(m);
                Console.WriteLine("Both real roots are equal -> x1=x2={0}", x);
            }
            else
            {
                Console.WriteLine("There are no real roots.");
            }
        }
    }
}
