using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheel
{
    class Corner
    {
        public int CornerBet(int roll)
        {
            int cornerNumber;
            int winnings = 0;
            int bet = 0;
            bool win = false;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };
            int[] column1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] userCorner = new int[4];

            Console.Write("You are making a corner bet. Select the number that will be located at the bottom left corner of your square: ");
            cornerNumber = Int32.Parse(Console.ReadLine());
            if (column1.Contains(cornerNumber) || column2.Contains(cornerNumber))
            {              
                userCorner[0] = cornerNumber;
                userCorner[1] = cornerNumber + 1;
                userCorner[2] = cornerNumber + 3;
                userCorner[3] = cornerNumber + 4;               
            }

            if (column3.Contains(cornerNumber))
            {
                userCorner[0] = cornerNumber;
                userCorner[1] = cornerNumber - 1;
                userCorner[2] = cornerNumber + 3;
                userCorner[3] = cornerNumber + 2;
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
                    foreach (int i in userCorner)
                    {
                        if (roll == i)
                        {
                            win = true;
                            break;
                        }
                        if (roll != i)
                        {
                            win = false;
                        }
                    }
                    if (win == true)
                    {
                        winnings = 8 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (win == false)
                    {
                        Console.WriteLine($"The roll was {roll} red.");
                        Console.WriteLine($"You lost ${bet}. You now have ${User.purse}.");
                    }
                }
                if (black.Contains(roll))
                {
                    foreach (int i in userCorner)
                    {
                        if (roll == i)
                        {
                            win = true;
                            break;
                        }
                        if (roll != i)
                        {
                            win = false;
                        }
                    }
                    if (win == true)
                    {
                        winnings = 8 * bet;
                        User.purse = winnings + User.purse;
                        Console.WriteLine($"The roll was {roll} black.");
                        Console.WriteLine($"You won ${winnings}. You now have ${User.purse}.");
                    }
                    if (win == false)
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
