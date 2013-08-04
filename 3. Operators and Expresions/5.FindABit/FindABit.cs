//using System;
//    class FindABit
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter a number: ");
//            byte num = byte.Parse(Console.ReadLine());
//            int p = 2;
//            int mask = 1 << p;
//            if ((num & mask) != 0)
//            {
//                Console.WriteLine(1);
//            }
//            else
//            {
//                Console.WriteLine(0);
//            }

//        }
//    }
using System;


class ChangePositionOfBytesPQ
{
    static void Main()
    {
        int number;
        byte bitPositionP, bitPositionQ, numberExchanges;

        Console.Write("Enter integer:\nn = ");
        number = int.Parse(Console.ReadLine());
        Console.Write("Enter first start position:\np = ");
        bitPositionP = byte.Parse(Console.ReadLine());
        Console.Write("Enter second start position:\nq = ");
        bitPositionQ = byte.Parse(Console.ReadLine());
        Console.Write("Enter how many exchanges you will make:\nk = ");
        numberExchanges = byte.Parse(Console.ReadLine());
        numberExchanges += 1;

        Console.WriteLine("The original value: {0}", Convert.ToString(number, 2));

        for (int i = bitPositionP, j = bitPositionQ; i < bitPositionP + numberExchanges - 1; i++, j++)
        {
            int maskP = 1 << i;
            int maskQ = 1 << j;
            int bitP = (number & maskP);
            int bitQ = (number & maskQ);

            int replace;
            if (bitP == 0)
            {
                replace = maskQ;
                number = (number & ~replace);
            }
            else
            {
                replace = maskQ;
                number = (number | replace);
            }

            if (bitQ == 0)
            {
                replace = maskP;
                number = (number & ~replace);
            }
            else
            {
                replace = maskP;
                number = (number | replace);
            }

        }
        Console.WriteLine("The number after bit exchanges is: {0}", number);
        Console.WriteLine("The after value is: {0}", Convert.ToString(number, 2));
    }
}