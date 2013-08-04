using System;
    class AgeIn10Years
    {
        static void Main()
        {
            Console.WriteLine("How old are you ? ");
            string ageString = Console.ReadLine();
            int ageNum = int.Parse(ageString);
            Console.WriteLine("Now you are" + "  " + ageNum + "  " + "years old !");
            int ageNum10 = ageNum + 10;
            Console.WriteLine("In 10 years you will be" + "  " + ageNum10 + "  " + " years old !");
        }
    }
