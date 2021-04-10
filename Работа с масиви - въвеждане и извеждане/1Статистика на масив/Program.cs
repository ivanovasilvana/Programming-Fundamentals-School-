using System;
using System.Linq;

namespace Работа_с_масиви___въвеждане_и_извеждане
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
                sum += array[i];
            }
            double average = (double)sum / array.Length;
            Console.Write($"Min = {min}\nMax = {max}\nSum = {sum}\nAverage = {average}");
        }
    }
}

