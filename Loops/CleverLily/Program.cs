﻿using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double savings = 0.0;
            double bDayMoney = 10;
            int toyCount = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += bDayMoney;
                    savings -= 1;
                    bDayMoney += 10;
                }
                else
                {
                    toyCount++;
                }

            }
            savings = savings + (toyPrice * toyCount);
            if (savings >= priceMachine)
            {
                Console.WriteLine($"Yes! {savings - priceMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceMachine - savings:f2}");
            }
        }
    }
}