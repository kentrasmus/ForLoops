﻿using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 98; i > 0; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. Take one down and pass it around, {i - 1} bottles of beer on the wall.");
                Console.WriteLine("");
                if(i == 1)
                {
                    Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer. Take one down and pass it around, no more bottles of beer on the wall.");
                    Console.WriteLine("");
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, 99 bottles of beer on the wall.");
                }
            }
        }
    }
}
