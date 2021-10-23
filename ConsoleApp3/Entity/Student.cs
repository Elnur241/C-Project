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
        public  List<int> Marks { get; set; }
        
         Student()
        {
            Marks = new List<int>();
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
        public  bool addMark( int mark)
        {
            Marks.Add(mark);
            return true;
        }
        public override string ToString()
        {
            return $"id:{id},Name:{Name},Surname:{Surname}";

        }
        public override bool Equals(object obj)
        {
            return this.Name.ToLower() == ((Student)obj).Name.ToLower();
        }
        //public int this[int index] { get; }
    }
}
