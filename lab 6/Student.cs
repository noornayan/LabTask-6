using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Student
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        private String department;

        public String Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }


        public Student()
        {
            Console.WriteLine("Empty Constructor called");
        }
    
        public Student(String name,String id,String department,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student id: " + id);
            Console.WriteLine("Student Department: " + department);
            Console.WriteLine("Student CGPA: " + cgpa+"\n\n");
            
        }
    }
}
