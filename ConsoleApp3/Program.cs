using ConsoleApp3.Entity;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            while (true) {
             Console.BackgroundColor = ConsoleColor.Green;
             Console.WriteLine("Menu:1-Add group|2-Add student|3-Add student mark|5View student list|5-Find student|6-Delete group|exit");
             Console.ResetColor();
            bool res= int.TryParse(Console.ReadLine(), out int result);
            if (res==true) 
            {
                if(result == 1)
                {
                    Console.WriteLine("Please enter group name");
                    string groupname = Console.ReadLine();
                    Group group = new Group(groupname);
                    groups.Add(group);
                   Console.WriteLine("Group lists");
                    foreach (Group item in groups)
                        {
                            Console.WriteLine("Groups:" + "id: " + Group.id + " group name: " + item.Name);
                     }
                        continue ;
                }
                else if (result == 2)
                {
                    Console.WriteLine("Please enter student name");
                    string studname = Console.ReadLine();
                    Console.WriteLine("Please enter student surname");
                    string studsurname = Console.ReadLine();
                        Student st = new Student(studname, studsurname);
                    Console.WriteLine("Please enter student group");
                        string grupname = Console.ReadLine();
                        for (int i = 0; i < groups.Count; i++)
                        {
                            if (grupname == groups[i].Name)
                            {
                                groups[i].addStudent(st);
                            }
                        }
                                      
                     continue;
                }
                else if (result == 3)
                    {

                    }
                else if(result==4)
                    {

                    }


            }
            else
            {
                Console.WriteLine("Please enter  the number!!!");
            }

            }

        }
    }
}
