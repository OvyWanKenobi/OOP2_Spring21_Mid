using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Student
    {

        private string name;
        private string id;
        private float cgpa;
        public Student() { }

        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }

        public string name
        {
            get { return name;}
            set { name = value; }
        }

        public string id
        {
                get { return id; }
                set { id = value; }
        }

        public float Cgpa
        {
            
                get { return cgpa; }
                set { cgpa = value; }
            
        }

        Department department; 

        public Department Department
        {
            get { return Department; }
            set { Department = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("CGPA: " + cgpa);
        }
    }
}
