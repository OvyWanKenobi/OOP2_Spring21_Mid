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

    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public Account() { }

        public string AccName
        {
            get
            { return accName; }
            set
            { accName = value; }
        }

        public string Acid
        {
            get
            { return acid; }
            set
            { acid = value; }
        }

        public int Balance
        {
            get
            { return balance; }
            set
            { balance = value; }
        }

        public void Deposit(int ammount)
        {
            balance = balance + ammount;
            Console.WriteLine("Deposited : " + ammount);

        }

        public void Withdraw(int ammount)
        {

            balance = balance - ammount;
            Console.WriteLine("Withdrawn : " + ammount);
        }
    }

    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;

        public String CourseName
        {
            get
            { return courseName; }
            set
            { courseName = value; }
        }

        public String CourseCode
        {
            get
            { return courseCode; }
            set
            { courseCode= value; }
        }

        public int CourseCredit
        {
            get
            { return courseCredit; }
            set
            { courseCredit = value; }
        }

        public void showCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Course Credit: " + courseCredit);
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

            Account a = new Account();
            a.AccName = "GameStop";
            a.Acid = "uwu420";
            a.Balance = 100;
            Console.WriteLine("Current Balance: " + a.Balance);
            a.Deposit(500);
            Console.WriteLine("Current Balance: " + a.Balance);
            a.Withdraw(200);
            Console.WriteLine("Current Balance: " + a.Balance);

            Console.WriteLine();

            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseCode = "CS420";
            c.CourseCredit = 3;
            c.showCourseInfo();


        }
    }
}
