using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheel
{
    public class Number 
    {
        public int NumbersBet(int roll)
        {
            int bet = 0;
            int number = 0;
            int winnings = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };

            Console.Write("Please enter the number you would like to bet on up to 36: ");
            number = Int32.Parse(Console.ReadLine());
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
                    Console.WriteLine($"The roll was {roll} red.");
                }
                if (black.Contains(roll))
                {
                    Console.WriteLine($"The roll was {roll} black.");
                }
                if (green.Contains(roll))
                {
                    if (roll == 00)
                    {
                        Console.WriteLine($"The roll was {roll} green.");
                    }
                    else
                    {
                        Console.WriteLine($"The roll was {roll} green.");
                    }
                }
                if (roll == number)
                {
                    winnings = 35 * bet;
                    User.purse = winnings + User.purse;
                    Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                }
                if (roll != number)
                {
                    Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                }
            }
            return User.purse;
        }
    }
}
