using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1c
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, ch, b, m, com, per;
            Console.WriteLine("Input mark of Physics:  ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input mark of Chemistry:  ");
            ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input mark of Biology  ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input mark of Mathematics:  ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input mark of Computer:  ");
            com = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("For Physics :");
            Console.Write("Percentage: ");
            per = (p * 100 / 100);
            Console.WriteLine(per);
            if (p >= 90)
            {
                Console.WriteLine("Grade : A+");
            }else if(p<=89 && p>85){
                Console.WriteLine("Grade: A");
            }else if (p<=85 && p >80)
            {
                Console.WriteLine("Grade: B+");
            }else if (p<=80 && p >75)
            {
                Console.WriteLine("Grade: B");
            }else if (p<=75 && p >50)
            {
                Console.WriteLine("Grade: C+");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }


            Console.WriteLine("For Chemistry :");
            Console.Write("Percentage: ");
            per = (ch * 100 / 100);
            Console.WriteLine(per);
            if (ch >= 90)
            {
                Console.WriteLine("Grade : A+");
            }
            else if (ch <= 89 && ch > 85)
            {
                Console.WriteLine("Grade: A");
            }
            else if (ch <= 85 && ch > 80)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (ch <= 80 && ch > 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (ch <= 75 && ch > 50)
            {
                Console.WriteLine("Grade: C+");
            }
            else 
            {
                Console.WriteLine("Grade: F");
            }


            Console.WriteLine("For Biology :");
            Console.Write("Percentage: ");
            per = (b * 100 / 100) ;
            Console.WriteLine(per);
            if (b >= 90)
            {
                Console.WriteLine("Grade : A+");
            }
            else if (b <= 89 && b > 85)
            {
                Console.WriteLine("Grade: A");
            }
            else if (b <= 85 && b > 80)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (b <= 80 && b > 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (b <= 75 && b > 50)
            {
                Console.WriteLine("Grade: C+");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }


            Console.WriteLine("For Maths :");
            Console.Write("Percentage: ");
            per = (m * 100 / 100);
            Console.WriteLine(per);
            if (m >= 90)
            {
                Console.WriteLine("Grade : A+");
            }
            else if (m <= 89 && m > 85)
            {
                Console.WriteLine("Grade: A");
            }
            else if (m <= 85 && m > 80)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (m <= 80 && m > 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (m <= 75 && m > 50)
            {
                Console.WriteLine("Grade: C+");
            }
            else 
            {
                Console.WriteLine("Grade: F");
            }


            Console.WriteLine("For Computer :");
            Console.Write("Percentage: ");
            per = (com *100 / 100);
            Console.WriteLine(per);
            if (com >= 90)
            {
                Console.WriteLine("Grade : A+");
            }
            else if (com <= 89 && com > 85)
            {
                Console.WriteLine("Grade: A");
            }
            else if (com <= 85 && com > 80)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (com <= 80 && com > 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (com <= 75 && com > 50)
            {
                Console.WriteLine("Grade: C+");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

        }
    }
}
