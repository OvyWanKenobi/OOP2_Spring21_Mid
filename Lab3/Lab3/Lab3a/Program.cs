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

    }


    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Ovywankenobi";
            Console.WriteLine("NAME: " + s.Name);
            s.ID = "38779";
            Console.WriteLine("ID: " + s.ID);
            s.Department = "CSE";
            Console.WriteLine("DEPARTMENT: " + s.Department);
            s.CG = 0.1F;
            Console.WriteLine("CGPA: " + s.CG);
        }
    }
}
