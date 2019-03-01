using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheel
{
    public class LowsHighs
    {
        public int LowOrHighBet(int roll)
        {
            string lowOrHigh;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };

            Console.Write("Would you like to bet on lows (1-18) or highs (19-36)? Please enter low/high: ");
            lowOrHigh = Console.ReadLine();
            lowOrHigh.ToLower();

            Console.Write($"You have ${User.purse}. Please enter how much you would like to bet: ");
            bet = Int32.Parse(Console.ReadLine());
            if (bet > User.purse)
            {
                throw new System.IndexOutOfRangeException("You bet more than you have.");
            }
            if (bet <= User.purse)
            {
                if (red.Contains(roll))
                {
                    User.purse = User.purse - bet;
                    if (roll <= 18 && roll >= 1 && lowOrHigh == "low")
                    {
                        winnings = 2 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll <= 18 && roll >= 1 && lowOrHigh != "low")
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (roll >= 19 && lowOrHigh == "high")
                    {
                        winnings = 2 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll >= 19 && lowOrHigh != "high")
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (roll == 0 || roll == 00)
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
                if (black.Contains(roll))
                {
                    User.purse = User.purse - bet;
                    if (roll <= 18 && roll >= 1 && lowOrHigh == "low")
                    {
                        winnings = 2 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll <= 18 && roll >= 1 && lowOrHigh != "low")
                    {
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (roll >= 19 && lowOrHigh == "high")
                    {
                        winnings = 2 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll >= 19 && lowOrHigh != "high")
                    {
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
                if (green.Contains(roll))
                {
                    if (roll == 0 || roll == 00)
                    {
                        Console.WriteLine($"The roll was {roll} green.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
            }
                return User.purse;
        }
    }
}
