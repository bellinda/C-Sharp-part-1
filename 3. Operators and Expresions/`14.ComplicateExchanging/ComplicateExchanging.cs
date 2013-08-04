using System;
    class ComplicateExchanging
    {
        static void Main()
        {
            Console.Write("Please enter any number of type \"uint\" to exchange bits {p,p+1,...,p+k-1}\n(counting of bits starting from 0) with bits {q,q+1,...,q+k-1}\nrespectively: ");
            uint input = uint.Parse(Console.ReadLine());
            Console.Write("p= ");
            byte pos1 = byte.Parse(Console.ReadLine());
            Console.Write("q= ");
            byte pos2 = byte.Parse(Console.ReadLine());
            Console.Write("k= ");
            byte len = byte.Parse(Console.ReadLine());
            uint numberToAdd1 = ((input << (32 - pos2 - len)) >> (32 - len)) << pos1;
            uint numbertoAdd2 = ((input >> pos1) << (32 - len)) >> (32 - pos2 - len);
            uint numberToAdd = numberToAdd1 + numbertoAdd2;
            uint numberToSubtract1 = numberToAdd1 << (pos2 - pos1);
            uint numberToSubtract2 = numbertoAdd2 >> (pos2 - pos1);
            uint numberToSubtract = numberToSubtract1 + numberToSubtract2;
            uint output = (input - numberToSubtract) + numberToAdd;
            Console.WriteLine();
            Console.WriteLine("Result: " + output);
            Console.WriteLine();
        }
    }

