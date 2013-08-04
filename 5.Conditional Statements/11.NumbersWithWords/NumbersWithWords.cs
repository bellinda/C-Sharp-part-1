using System;
    class NumbersWithWords
    {
        static void Main()
        {
            Console.Write("Enter a number between 0 and 999: ");
            int num = int.Parse(Console.ReadLine());
            int ones = num % 10;
            num /= 10;
            int tens = num % 10;
            num /= 10;
            int hundreds = num % 10;
            if (num >= 0 && num <= 999)
            {
                switch (hundreds)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("One hundred ");
                        break;
                    case 2:
                        Console.Write("Two hundred ");
                        break;
                    case 3:
                        Console.Write("Three hundred ");
                        break;
                    case 4:
                        Console.Write("Four hundred ");
                        break;
                    case 5:
                        Console.Write("Five hundred ");
                        break;
                    case 6:
                        Console.Write("Six hundred");
                        break;
                    case 7:
                        Console.Write("Seven hundred ");
                        break;
                    case 8:
                        Console.Write("Eight hundred ");
                        break;
                    case 9:
                        Console.Write("Nine hundred ");
                        break;
                }
                switch (tens)
                {
                    case 0:
                        if ((hundreds == 0) || (ones == 0))
                            break;
                        else
                            Console.Write("and ");
                        break;
                    case 1:
                        if (hundreds == 0) break;
                        else
                            Console.Write("and ");
                        break;
                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("fourty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eighty ");
                        break;
                    case 9:
                        Console.Write("ninty ");
                        break;
                }

                switch (ones)
                {
                    case 0:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("Zero \n");
                        else
                            break;
                        break;
                    case 1:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("one\n");
                        else if (tens == 0)
                            Console.Write("one\n");
                        else if (tens == 1)
                            Console.Write("eleven \n");
                        else
                            Console.Write("one\n");
                        break;
                    case 2:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("two\n");
                        else if (tens == 0)
                            Console.Write("two\n");
                        else if (tens == 1)
                            Console.Write("twelve\n");
                        else
                            Console.Write("two\n");
                        break;
                    case 3:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("three\n");
                        else if (tens == 0)
                            Console.Write("three\n");
                        else if (tens == 1)
                            Console.Write("thirteen\n");
                        else
                            Console.Write("three\n");
                        break;
                    case 4:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("four\n");
                        else if (tens == 0)
                            Console.Write("four\n");
                        else if (tens == 1)
                            Console.Write("fourteen\n");
                        else
                            Console.Write("four\n");
                        break;
                    case 5:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("five\n");
                        else if (tens == 0)
                            Console.Write("five\n");
                        else if (tens == 1)
                            Console.Write("fifteen\n");
                        else
                            Console.Write("five\n");
                        break;
                    case 6:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("six\n");
                        else if (tens == 0)
                            Console.Write("six\n");
                        else if (tens == 1)
                            Console.Write("sixteen\n");
                        else
                            Console.Write("six\n");
                        break;
                    case 7:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("seven\n");
                        else if (tens == 0)
                            Console.Write("seven\n");
                        else if (tens == 1)
                            Console.Write("seventeen\n");
                        else
                            Console.Write("seven\n");
                        break;
                    case 8:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("eight\n");
                        else if (tens == 0)
                            Console.Write("eight\n");
                        else if (tens == 1)
                            Console.Write("eighteen\n");
                        else
                            Console.Write("eight\n");
                        break;
                    case 9:
                        if (hundreds == 0 && tens == 0)
                            Console.Write("nine\n");
                        else if (tens == 0)
                            Console.Write("nine\n");
                        else if (tens == 1)
                            Console.Write("nineteen\n");
                        else
                            Console.Write("nine\n");
                        break;
                }
            }
            else
                Console.WriteLine("Incorrect input!\n");
        }
    }
