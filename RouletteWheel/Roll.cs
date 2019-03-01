﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheel
{
    public class WheelRoll
    {
        public static int Roll()
        {
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };
            int[] wheel = new int[38];
            Random rand = new Random();
            int roll = rand.Next(wheel.Length);

            if (green.Contains(roll))
            {
                if (roll == 37)
                {
                    roll = 00;                  
                }         
            }
            return roll;
        }
    }
}
