using System;
    class CardsCombinations
    {
        static void Main()
        {
            int card,type;
            string colour ="";
            string number = "";
            for (card = 1; card <= 13; card++)
            {
                switch (card)
                {
                    case 1:
                        number = "Ace ";
                        break;
                    case 2:
                        number = "two ";
                        break;
                    case 3:
                        number = "three ";
                        break;
                    case 4:
                        number = "four ";
                        break;
                    case 5:
                        number = "five ";
                        break;
                    case 6:
                        number = "six ";
                        break;
                    case 7:
                        number = "seven ";
                        break;
                    case 8:
                        number = "eight ";
                        break;
                    case 9:
                        number = "nine ";
                        break;
                    case 10:
                        number = "ten ";
                        break;
                    case 11:
                        number = "Jack ";
                        break;
                    case 12:
                        number = "Queen ";
                        break;
                    case 13:
                        number = "King ";
                        break;

                }
                for (type = 1; type <= 4; type++)
                {
                    switch (type)
                    {
                        case 1:
                            colour = "of Spades";
                            break;
                        case 2:
                            colour = "of Hearts";
                            break;
                        case 3:
                            colour = "of Diamonds";
                            break;
                        case 4:
                            colour = "of Clubs";
                            break;
                    }
                    Console.WriteLine(number + colour);
                }
                
            }
        }
    }
