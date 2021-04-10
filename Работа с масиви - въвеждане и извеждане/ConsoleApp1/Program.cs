using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MostCommonNumber
    {
        class Program
        {
            // 2. Най-често срещано число
            static void Main(string[] args)
            {
                // Входни данни
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                // Намираме броя на срещанията на всяко число
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                    

                // Намираме най-често срещаното число
               
                for (int j = 0; j < array.Length; i++)
                    if (count[i] > maxValue)
                    {
                        maxValue = count[i];
                        maxIndex = i;
                    }
                Console.WriteLine(maxIndex);

                // TODO: При равен брой срещания намерете най-лявото
            }
        }
    }
}
}
