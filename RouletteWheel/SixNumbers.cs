using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheel
{
    public class SixNumbers
    {
        public int SixNumberBet(int roll)
        {
            int street;
            int rangeOfStreet;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };

            Console.Write("You are making a six number bet. The board has been split into 6 rows. To select a specific two rows of numbers please enter the lowest number in the street you wish to choose: ");
            street = Int32.Parse(Console.ReadLine());
            rangeOfStreet = street + 5;

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
                    if (roll <= rangeOfStreet && roll >= 1)
                    {
                        winnings = 6 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll > rangeOfStreet)
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
                if (black.Contains(roll))
                {
                    if (roll <= rangeOfStreet && roll >= 1)
                    {
                        winnings = 6 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll > rangeOfStreet)
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
