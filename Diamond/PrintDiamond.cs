﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class PrintDiamond
    {

        // Prints the Diamond in console based on Rows & letter
        public static void Print(int n)
        {
            var rows = Math.Ceiling((decimal)n / 2);
            // run loop   
            // til number of rows 
            var outsideSpace = (int)rows;
            var insideSpace = 1;

            for (var i = 1; i <= rows; i++)
            {
                for (var k = 1; k < outsideSpace; k++) Console.Write(" ");

                for (var j = 1; j <= i; j++)
                {
                    if (j >= 3) break;
                    Console.Write((char)(i + 64));

                    for (var k = 1; k < insideSpace; k++) Console.Write(" ");
                }


                outsideSpace--;
                insideSpace += 2;


                Console.Write("\n");
            }

            // Repeat again in reverse order minus one row (entered character only gets one row)
            var down = n - rows;
            insideSpace -= 2;

            // run loop (parent loop) 
            // till number of rows 
            for (var i = (int)down; i > 0; i--)
            {
                outsideSpace++;
                insideSpace -= 2;

                for (var k = 1; k <= outsideSpace; k++) Console.Write(" ");

                for (var j = 1; j <= i; j++)
                {
                    // Don't want to fill in the diamond
                    if (j >= 3) break;
                    Console.Write((char)(i + 64));

                    for (var k = 1; k < insideSpace; k++) Console.Write(" ");
                }

                Console.Write("\n");
            }
        }
    }
}
