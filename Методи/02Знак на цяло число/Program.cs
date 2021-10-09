﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Знак_на_цяло_число
{
    class Program
    {
        static void PrintSign(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
