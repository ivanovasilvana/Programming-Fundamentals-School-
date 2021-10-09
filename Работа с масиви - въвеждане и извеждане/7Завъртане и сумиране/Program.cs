using System;
using System.Linq;

namespace _7Завъртане_и_сумиране
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int countOfRotation = int.Parse(Console.ReadLine());

            int[] rotatedArray = new int[array.Length];
            int[] sum = new int[array.Length];

            for (int i = 0; i < countOfRotation; i++)
            {
                int rotate = array[0];
                array[0] = array[array.Length - 1];

                for (int j = 0; j < array.Length; j++)
                {
                   
                    for (int k = array.Length-1; k > 2; k--)
                    {
                        array[k] = array[k - 1];
                    }
                }
                array[1] = rotate;

                /*
                    for (int k = 1; k < array.Length-; k++)
                    {

                        rotate = array[k];
                        array[k] = array[k + 1];
                    }

                }
               */
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
