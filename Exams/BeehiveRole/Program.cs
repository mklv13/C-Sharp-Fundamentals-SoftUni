﻿using System;

namespace BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteligence = int.Parse(Console.ReadLine());
            int strength = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string role = "";

            if (inteligence >= 80)
            {
                if (strength >= 80 && gender == "female")
                {
                    role = "Queen Bee";
                }
                else
                {
                    role = "Repairing Bee";
                }
            }
            else if (inteligence >= 60)
            {
                role = "Cleaning Bee";
            }
            else
            {
                if (strength >= 80 && gender == "male")
                {
                    role = "Drone Bee";
                }
                else if (strength >= 60)
                {
                    role = "Guard Bee";
                }
                else
                {
                    role = "Worker Bee";
                }
            }
            Console.WriteLine(role);
        }
    }
}
