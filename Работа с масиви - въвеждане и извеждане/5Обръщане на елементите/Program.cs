using System;

namespace _5Обръщане_на_елементите
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int[] newArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }
            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[(length - 1) - i];
            }
            Console.WriteLine(string.Join(' ', newArray));
        }
    }
}
