using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < newArray.Length - 1; j++)
                {

                    if (num < array[j])
                    {
                        newArray[j] = num;
                    }
                    else
                    {
                        newArray[j + 1] = array[i];
                    }
                }

            }
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
