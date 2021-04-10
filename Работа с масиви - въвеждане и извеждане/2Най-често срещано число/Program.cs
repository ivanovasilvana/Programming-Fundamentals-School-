using System;
using System.Linq;

namespace _2Най_често_срещано_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int element = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];
                int currentCounter = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (currentElement == array[j])
                    {
                        currentCounter++;
                    }
                }
                if (currentCounter > counter)
                {
                    counter = currentCounter;
                    element = currentElement;
                }
            }
            Console.WriteLine(element);
        }
    }
}