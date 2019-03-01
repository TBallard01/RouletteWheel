using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheel
{
    public class Columns
    {
        public int ColumnBet(int roll)
        {
            string column;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };
            int[] column1 = {1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34};
            int[] column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };


            Console.Write("You are making a street bet. The board has been split into 12 rows. To select a specific row of numbers please enter the first number of the street : ");
            column = Console.ReadLine();
            column.ToLower();

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
                    if (column1.Contains(roll) && column == "first")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (column1.Contains(roll) && column != "first")
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (column2.Contains(roll) && column == "second")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (column2.Contains(roll) && column != "second")
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (column3.Contains(roll) && column == "third")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (column2.Contains(roll) && column != "third")
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
                if (black.Contains(roll))
                {
                    if (column1.Contains(roll) && column == "first")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (column1.Contains(roll) && column != "first")
                    {
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (column2.Contains(roll) && column == "second")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (column2.Contains(roll) && column != "second")
                    {
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                    if (column3.Contains(roll) && column == "third")
                    {
                        winnings = 3 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (column3.Contains(roll) && column != "third")
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
