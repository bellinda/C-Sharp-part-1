using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

namespace JustSnake
{
    
    struct Position
    {
        public int row;
        public int col;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

    }

    class JustSnake
    {
        static void Main(string[] args)
        {
            int lastFoodTime = 0;
            int foodDisapearTime = 8000;
            string dequeue;
            Position[] directions = new Position[]
            {
                new Position(0,1),  //right
                new Position(0,-1), //left
                new Position(1,0),  //down
                new Position(-1,0)  //up
            };
            int direction = 0; //by default змията ще се мести на дясно

            Console.BufferHeight = Console.WindowHeight;
            int middleRow = Console.WindowHeight / 2;
            int middleCol = Console.WindowWidth/2;
            Random randomNumbersGenerator = new Random();
            Position food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
            

            Queue<Position> snakeElements = new Queue<Position>();
            Position position1 = new Position(0, 0);   //Въвеждане на началната позиция на змията
            Position position2 = new Position(0, 1);
            Position position3 = new Position(0, 2);
            Position position4 = new Position(0, 3);
            Position position5 = new Position(0, 4);
            Position position6 = new Position(0, 5);
            snakeElements.Enqueue(position1);
            snakeElements.Enqueue(position2);
            snakeElements.Enqueue(position3);
            snakeElements.Enqueue(position4);
            snakeElements.Enqueue(position5);
            snakeElements.Enqueue(position6);

            foreach (Position position in snakeElements) //рисуваме първата змия
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("*");
            }


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        direction = 1; //left
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        direction = 0; //right
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        direction = 3; //up
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        direction = 2; //down
                    }
                }

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);
                if (snakeNewHead.row < 0 || snakeNewHead.col < 0 || snakeNewHead.row >= Console.WindowHeight || snakeNewHead.col >= Console.WindowWidth || snakeElements.Contains(snakeNewHead))
                {
                    Console.SetCursorPosition(middleCol-5,middleRow);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Game over!");
                    Console.SetCursorPosition(middleCol-9,middleRow+1);
                    Console.WriteLine("Your points are {0}", (snakeElements.Count-6)*100);
                    return;
                }

                Console.SetCursorPosition(snakeHead.col, snakeHead.row);
                Console.Write("*");

                snakeElements.Enqueue(snakeNewHead);
                Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                
                Console.Write("*");
                if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                {
                    do
                    {
                        food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
                    }
                    while (snakeElements.Contains(food));
                    Console.SetCursorPosition(food.col, food.row);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    lastFoodTime = Environment.TickCount;
                    Console.Write("@");

                }
                else
                {
                    snakeElements.Dequeue();
                }
                
                Console.Clear();

                foreach (Position position in snakeElements)
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("*");
                }

                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                lastFoodTime = Environment.TickCount;
                Console.Write("@");
 
                Thread.Sleep(100);

 
 
            }
        }
    }
}
