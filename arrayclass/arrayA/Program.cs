using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayA
{
    class Program
    {
        static void Main(string[] args)
        {

            // EXERCISE A : COPY ELEMENTS
            Console.WriteLine("EXERCISE A : COPY ELEMENTS");

            int[]arr1 = new int[]{ 1, 3, 5, 7, 9 };
            int[]arr2 = new int[10];

            for (int i=0; i<arr1.Length; i++)
            {
                arr2[i]=arr1[i];
            }

            Console.Write("Elements of the first array: ");
            for (int i=0; i<arr1.Length; i++)
            {
                Console.Write(arr1[i]+" ");
            }
            Console.WriteLine("");
    
            Console.Write("Elements of the second array: ");
            for (int i=0; i<arr1.Length; i++)
            {
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine();


            // EXERCISE B : COUNT DUBLICATE ELEMENTS
            Console.WriteLine("EXERCISE B : COUNT DUBLICATE ELEMENTS");

            int[] arr3 = new int[]{ 2, 2, 4, 6, 6, 8, 9, 10};
            int count = 0;

            for (int i=0; i<arr3.Length; i++)
            {
                for (int j=i+1; j<arr3.Length; j++)
                {
                    if (arr3[i]==arr3[j])
                    {
                        count++;
                    }
                }
            }

            Console.Write("Elements of the array: ");
            for (int i=0; i<arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Total number of duplicate elements in the array:" + count);
            Console.WriteLine();

            //Exercise C : PRINT UNIQUE ELEMENTS
            Console.WriteLine("EXERCISE C : PRINT UNIQUE ELEMENTS");

            int unique;

            int[] arr4 = new int[] { 2, 2, 4, 5, 6, 6, 7, 8, 9, 9 };
            Console.Write("Elements of the array: ");
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Unique elements in the array are: ");
            for (int i=0; i<arr4.Length; i++)
            {
                unique=0;

                for (int j=0; j<i-1; j++)
                {
                 
                    if (arr4[i]==arr4[j])
                    {
                        unique++;
                    }
                }

                for (int k=i+1; k<arr4.Length; k++)
                {
                    if (arr4[i]==arr4[k])
                    {
                        unique++;
                    }

                    if (arr4[i] == arr4[i+1])
                    {
                        i++;
                    }
                }
            
                
                if (unique==0)
                {
                   
                    Console.Write(arr4[i]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
