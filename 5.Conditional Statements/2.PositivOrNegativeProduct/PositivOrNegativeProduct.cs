using System;
class PositivOrNegativeProduct
{
    static void Main()
    {
        Console.WriteLine("Enter three integers - no matter positiv or negative, but on different lines, please:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The sign of their product is +");
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The sign of their product is -");
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The sign of their product is -");
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The sign of their product is -");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The sign of their product is +");
        }
        else if (a < 0 && c < 0 && b > 0)
        {
            Console.WriteLine("The sign of their product is +");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The sign of their product is +");
        }
        else
        {
            Console.WriteLine("The sign of their product is -");
        }
    }
}