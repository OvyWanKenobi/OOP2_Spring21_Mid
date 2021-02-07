using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Input the end of range:  ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even Numbers :");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
