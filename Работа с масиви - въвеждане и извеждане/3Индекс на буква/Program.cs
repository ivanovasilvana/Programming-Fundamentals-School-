using System;

namespace _3Индекс_на_буква
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = new char[input.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = input[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} -> {array[i] - 97}");
            }
        }
    }
}
