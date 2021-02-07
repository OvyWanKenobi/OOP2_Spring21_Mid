using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3a
{

    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student() { }

        public string Name
        {
            get
            {return name; }
            set
            {name = value; }
        }
        public string ID
        {
            get
            { return id; }
            set
            { id = value; }
        }
        public string Department
        {
            get
            { return department; }
            set
            { department = value; }
        }
     
        public float CG
        {
            get
            { return cgpa; }
            set
            { cgpa = value; }
        }

        public void showinfo()
        {
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("DEPARTMENT: " + Department);
            Console.WriteLine("CGPA: " + CG);
        }
    }

    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public Triangle() { }

        public int X
        {
            get
            { return x; }
            set
            { x = value; }
        }

        public int Y
        {
            get
            { return y; }
            set
            { y = value; }
        }

        public int Z
        {
            get
            { return z; }
            set
            { z = value; }
        }

        public void showinfo()
        {
            Console.WriteLine("Side X: " + x);
            Console.WriteLine("Side Y: " + y);
            Console.WriteLine("Side Z: " + z);
        }
        public void testTriangle()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("Triangle is equilateral");
            }
            else if (x == y && x != z || y == z && y != x || z == x && x != y)
            {
                Console.WriteLine("Triangle is isoscale");
            }
            else
            {
                Console.WriteLine("Triangle is scalane");
            }

        }

    }

        class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Ovywankenobi";
            s.ID = "38779";
            s.Department = "CSE";
            s.CG = 0.1F;
            s.showinfo();

            Console.WriteLine();

            Triangle t = new Triangle();
            t.X = 1;
            t.Y = 3;
            t.Z = 3;
            t.showinfo();
            t.testTriangle();

            Console.WriteLine();
        }
    }
}
