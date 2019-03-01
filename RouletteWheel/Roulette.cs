using RouletteWheel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    public class Roulette : WheelRoll
    { 
        public static void Main(string[] args)
        {
            bool play;
            string playAgain;

            while (play = true && User.purse > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Roulette. Please reference the options below to select which bet you would like to make.");
                Console.WriteLine("(1) Number Bet \n(2) Evens or Odds \n(3) Reds or Blacks \n(4) Lows or Highs \n(5) Dozens \n(6) Columns \n(7) Street \n(8) 6 Numbers \n(9) Split \n(10) Corner");
                Console.Write("Please enter the number associated with the bet you wish to make: ");
                int chosenBet = Int32.Parse(Console.ReadLine());
                if (chosenBet > 10)
                {
                    throw new IndexOutOfRangeException("You chose a number that does not correspond with any of the bets.");
                }
                if (chosenBet == 1)
                {
                    Number number = new Number();
                    number.NumbersBet(Roll());
                }
                if (chosenBet == 2)
                {
                    EvenOrOdd evenorodd = new EvenOrOdd();
                    evenorodd.EvenOrOddBet(Roll());
                }
                if (chosenBet == 3)
                {
                    RedOrBlack redorblack = new RedOrBlack();
                    redorblack.RedOrBlackBet(Roll());
                }
                if (chosenBet == 4)
                {
                    LowsHighs loworhigh = new LowsHighs();
                    loworhigh.LowOrHighBet(Roll());
                }
                if (chosenBet == 5)
                {
                    Dozens dozens = new Dozens();
                    dozens.DozensBet(Roll());
                }
                if (chosenBet == 6)
                {
                    Columns columns = new Columns();
                    columns.ColumnBet(Roll());
                }
                if (chosenBet == 7)
                {
                    Street street = new Street();
                    street.StreetBet(Roll());
                }
                if (chosenBet == 8)
                {
                    SixNumbers sixNumbers = new SixNumbers();
                    sixNumbers.SixNumberBet(Roll());
                }
                if (chosenBet == 9)
                {
                    Split split = new Split();
                    split.SplitBet(Roll());
                }
                if (chosenBet == 10)
                {
                    Corner corner = new Corner();
                    corner.CornerBet(Roll());
                }
                if (User.purse == 0)
                {
                    play = false;
                    Console.WriteLine("Thank you for playing. Good bye.");
                    Console.ReadKey();
                }
                if (User.purse > 0)
                {
                    Console.Write("Would you like to play again (yes/no): ");
                    playAgain = Console.ReadLine();
                    playAgain.ToLower();
                    if (playAgain == "yes")
                    {
                        play = true;
                        Random random = new Random();
                        int phrase = random.Next(1, 3);
                        if (phrase == 1)
                        {
                            Console.WriteLine("You'll certainly win more this time!");
                        }
                        if (phrase == 2)
                        {
                            Console.WriteLine("Ah you like to live life on the edge. Fantastic lets play again!");
                        }
                        if (phrase == 3)
                        {
                            Console.WriteLine("Luck is for the unskilled. You must be a very lucky person.");
                        }
                    }
                    else if (playAgain == "no")
                    {
                        play = false;
                        Console.WriteLine("Thank you for playing. Good bye.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
