using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    class Group
    {
        public static int id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int MaxStudentCount { get; set; } = 40;
        //public static List<Group> groups { get; set; }
        public List<Student> students { get; set; }
        public Group()
        {
            int count = 0;
            count++;
            id = id + count;
        }
        public Group(string name)
        {

        }
        public Group(string name,int number,int maxstudent)
        {
            this.Name = name;
            this.Number = number;
            this.MaxStudentCount = maxstudent;

        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }
    }
}
