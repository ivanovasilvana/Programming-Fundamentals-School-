﻿using System;
using System.Linq;
namespace _6.Обръщане_на_масив_от_символни_низове
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            array.Reverse();
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
