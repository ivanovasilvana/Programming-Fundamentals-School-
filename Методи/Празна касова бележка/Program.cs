using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Празна_касова_бележка
{
    class Program
    {
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void Basic()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");

        }
        static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© BG");
        }
        static void Receipt()
        {
            Header();
            Basic();
            Footer();
        }
        static void Main(string[] args)
        {
            Receipt();
        }
    }
}
