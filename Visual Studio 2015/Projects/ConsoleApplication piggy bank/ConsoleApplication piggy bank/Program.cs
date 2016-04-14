﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_piggy_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Piggy Bank");
            int[] coins = new int[6];
            
            Console.WriteLine("Please enter in the number of Pennies you have ");
            coins[0]= int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of Nickels you have ");
            coins[1]= int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of dimes you have ");
            coins[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of Quarter you have ");
            coins[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of Half Dollar you have ");
            coins[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of Dollar you have ");
            coins[5] = int.Parse(Console.ReadLine());

            decimal totalCents = coins[0] + (coins[1] * 5) + (coins[2] * 10) + (coins[3] * 25) + (coins[4] * 50) + (coins[5] * 100);
            decimal finalAmount = totalCents / 100;
            Console.WriteLine(finalAmount);

            Console.WriteLine(finalAmount % 20);
            decimal twenty = finalAmount - (finalAmount % 20);
            Console.WriteLine("You can get {0} twenty dollar bills.", twenty / 20);



        }


    }
    }


