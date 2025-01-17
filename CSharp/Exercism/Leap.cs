﻿namespace CSharp.Exercism
{
    public static class Leap
    {
        public static bool Run(int year)
        {
            bool isLeap = false;

            if (year % 400 == 0)
            {
                isLeap = true;
            }
            else if (year % 100 == 0)
            {
                isLeap = false;
            }
            else if (year % 4 == 0)
            {
                isLeap = true;
            }

            var response = isLeap ? "IS" : "is NOT";
            Console.WriteLine($"{year} {response} a leap year");

            return isLeap;
        }
    }
}
