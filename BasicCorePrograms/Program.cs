﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1. Largest Among Three Numbers");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Enter number of times to Flip Coin:");
                    int Count = Convert.ToInt32(Console.ReadLine());
                    FlipCoin.HeadTail(Count);
                    break;
                default:
                    Console.WriteLine("Please select option in range.");
                    break;
            }
            Console.ReadLine();
        }
    }
}