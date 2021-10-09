using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Търсене_на_елемент_в_сортиран_масив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            bool isFound = false;


            for (int i = 0; i < array.Length; i++)
            {
                if (num == array[i])
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
