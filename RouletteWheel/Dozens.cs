using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheel
{
    public class Dozens
    {

            public int DozensBet(int roll)
            {
                string dozen;
                int winnings = 0;
                int bet = 0;
                int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
                int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
                int[] green = { 0, 37 };

            Console.Write("You are making a dozens bet. The board has been split into 3 (1-12), (13-24), and (25-36). To select a specific dozen numbers please enter first, second, or third as they relate to how the board has been divided: ");
                dozen = Console.ReadLine();
                dozen.ToLower();

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
                    if (roll <= 12 && roll >= 1 && dozen == "first")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll <= 12 && roll >= 1 && dozen != "first")
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (roll >= 13 && roll <= 24 && dozen == "second")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll >= 13 && roll <= 24 && dozen != "second")
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (roll >= 25 && roll <= 36 && dozen == "third")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll >= 25 && roll <= 36 && dozen != "third")
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
                if (black.Contains(roll))
                {
                    if (roll <= 12 && roll >= 1 && dozen == "first")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll <= 12 && roll >= 1 && dozen != "first")
                    {
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (roll >= 13 && roll <= 24 && dozen == "second")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll >= 13 && roll <= 24 && dozen != "second")
                    {
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (roll >= 25 && roll <= 36 && dozen == "third")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (roll >= 25 && roll <= 36 && dozen != "third")
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
