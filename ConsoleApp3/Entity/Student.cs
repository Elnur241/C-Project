using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
        public static int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string GroupNumber { get; set; }
        public int Point { get; set; }
        public Student()
        {
            int count =0;
            count++;
            id = id + count;

        }
        public Student(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
