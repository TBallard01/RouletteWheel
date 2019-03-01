using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheel
{
    class Split
    {
        public int SplitBet(int roll)
        {
            int splitNumber1;
            int splitNumber2 = 0;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };
            int[] column1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

            Console.Write("You are making a split bet. Select your first number: ");
            splitNumber1 = Int32.Parse(Console.ReadLine());
            if (column1.Contains(splitNumber1))
            {
                if (splitNumber1 == 1)
                {
                    Console.Write("Please enter the number you wish to split with (2, or 4): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 == 34)
                {
                    Console.Write("Please enter the number you wish to split with (31, or 35): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 != 1 && splitNumber1 != 34)
                {
                    Console.Write($"Please enter the number you wish to split with ({splitNumber1 - 3}, {splitNumber1 + 1}, or {splitNumber1 + 3}): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
            }
            if (column2.Contains(splitNumber1))
            {
                if (splitNumber1 == 2)
                {
                    Console.Write("Please enter the number you wish to split with (1, 3, or 5): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 == 35)
                {
                    Console.Write("Please enter the number you wish to split with (32, 34, 36): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 != 2 && splitNumber1 != 35)
                {
                    Console.Write($"Please enter the number you wish to split with ({splitNumber1 - 3}, {splitNumber1 - 1}, {splitNumber1 + 1}, or {splitNumber1 + 3}): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
            }
            if (column3.Contains(splitNumber1))
            {
                if (splitNumber1 == 3)
                {
                    Console.Write("Please enter the number you wish to split with (2, or 6): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 == 36)
                {
                    Console.Write("Please enter the number you wish to split with (33, or 35): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 != 3 && splitNumber1 != 36)
                {
                    Console.Write($"Please enter the number you wish to split with ({splitNumber1 - 3}, {splitNumber1 - 1}, or {splitNumber1 + 3}): ");
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
            }

            Console.Write($"You have ${User.purse}. Please enter how much you would like to bet: ");
            bet = Int32.Parse(Console.ReadLine());
            if (bet > User.purse)
            {
                throw new System.IndexOutOfRangeException("You bet more than you have.");
            }
            if (bet <= User.purse)
            {
                User.purse = User.purse - bet;
                if (red.Contains(roll))
                {
                    if (roll == splitNumber1 || roll == splitNumber2)
                    {
                        winnings = 17 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll != splitNumber1 || roll != splitNumber2)
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
                if (black.Contains(roll))
                {
                    if (roll == splitNumber1 || roll == splitNumber2)
                    {
                        winnings = 17 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll != splitNumber1 || roll != splitNumber2)
                    {
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
                if (roll == 0 || roll == 00)
                {
                    Console.WriteLine($"The roll was {roll} green.");
                    Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                }
            }
            return User.purse;
        }
    }
}
