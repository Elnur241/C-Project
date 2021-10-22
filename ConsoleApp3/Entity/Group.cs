using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    class Group
    {
       
        public  int id { get; set; }
        private static int count = 0;
        public string Name { get; set; }
        public int studentCount { get; set; }
        public int MaxStudentCount { get; set; } 
        //public static List<Group> groups { get; set; }
        public List<Student> students { get; set; }
         Group()
        {
            students = new List<Student>();
            count++;
            id =count;
          
        }
        public Group(string name):this()
        {
            this.Name = name;
        }
        public Group(string name,  int maxstudent):this()
        {
            this.Name = name;
            this.MaxStudentCount = maxstudent;

        }
        public Group(string name,int studentCount, int maxstudent):this()
        {
            this.Name = name;
            this.studentCount = studentCount;
            this.MaxStudentCount = maxstudent;

        }
        public override string ToString()
        {
            return $"Id:{id}, Name: {Name}, MaxCount:{MaxStudentCount},CurrentStudentCount:{studentCount}";
        }
       
        public override bool Equals(object obj)
        {
            return this.Name == ((Group)obj).Name;
        }
        public bool addStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
                return true;
            }
            else
            {
                Console.WriteLine("There is user already.");
                return false;
            }
        }
    }
}
