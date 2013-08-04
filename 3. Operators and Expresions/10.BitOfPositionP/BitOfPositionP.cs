using System;
class BitOfPositionP
{
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number of position in the integer you want to check: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        Console.WriteLine((v & mask) != 0 ? true:false);

    }
}