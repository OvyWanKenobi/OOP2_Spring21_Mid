using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers from 1 to 100 :");
            for (int i=1; i<=100; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write(i+" ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Odd Numbers from 1 to 100 :");
            for (int i=1; i<=100; i++)
            {
                if (i%2 != 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();

        }
    }
}
