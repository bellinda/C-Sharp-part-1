using System;
    class StringAndObjectVariables
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World";
            object together = first + ", " + second + "!";
            string third = (string)together;
            Console.WriteLine(third);
        }
    }
