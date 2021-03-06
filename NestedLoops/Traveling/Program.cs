﻿using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double sumIncreased = 0;
                while (sumIncreased < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    sumIncreased += money;

                    if (budget <= sumIncreased)
                    {
                        Console.WriteLine($"Going to {input}!");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}