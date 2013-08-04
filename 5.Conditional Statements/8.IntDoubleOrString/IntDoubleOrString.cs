using System;
    class IntDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("What kind of variable do you want to enter?");
            Console.WriteLine("Choose 1 for integer, 2 for double and three for string");
            byte choice = byte.Parse(Console.ReadLine());
            int intInput;
            double doubleInput;
            string StringInput;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("So enter an integer:");
                    intInput = int.Parse(Console.ReadLine());
                    int b = intInput + 1;
                    Console.WriteLine(b);
                    break;
                case 2:
                    Console.WriteLine("So enter a value of double type:");
                    doubleInput = double.Parse(Console.ReadLine());
                    double d = doubleInput + 1d;
                    Console.WriteLine(d);
                    break;
                case 3:
                    Console.WriteLine("So enter a value of string type: ");
                    string stringInput = Convert.ToString(Console.ReadLine());
                    string f = stringInput + "*";
                    Console.WriteLine(f);
                    break;
            }

        }
    }

