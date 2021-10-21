using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
        private static int count = 0;
        public  int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string GroupNumber { get; set; }
        public static List<int> Marks { get; set; }
        
         Student()
        {
            count++;
            id =  count;
        }
        public Student(string name) : this()
        {
            this.Name = name;
        }
     
        public Student(string name,string surname):this()
        {
            this.Name = name;
            this.Surname = surname;
        }
        public static void addMark( int mark)
        {
            Marks.Add(mark);
        }
        public override string ToString()
        {
            return base.ToString();

        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        //public int this[int index] { get; }
    }
}
