using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Department
    {
        private string name;
        private string id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private Student[] students;
        public Department() {
            students = new Student[60];
        }

        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
            students = new Student[60];
        }

        private int studentCount;
        public void AddStudent(params Student[] arrStudent)
        {
            foreach (var s in arrStudent)
            {
                students[studentCount++] = s;
                s.Department = this;
            }
        }

        public void AllStudent()
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].ShowInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Depart Name: " + name);
            Console.WriteLine(" Depart Id: " + id);
        }
    }
}
