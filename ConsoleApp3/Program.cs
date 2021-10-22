using ConsoleApp3.Entity;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCurrCount = 0;
            List<Group> groups = new List<Group>();
            while (true) {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Menu:1-Add group|2-Add student|3-Add student mark|4-View student list|5-Find student|6-Delete group|Exit-exit");
                Console.ResetColor();
                string number = Console.ReadLine().ToLower();
             bool res= int.TryParse(number, out int result);
             if (res==true && result<=6) 
             {
                if(result == 1)
                {
                    Console.WriteLine("Please enter group name:");
                       
                    string groupname = Console.ReadLine();
                        if (groupname.Length == 0)
                        {
                            Console.WriteLine("Group name must not be null");  
                        }
                        else {
                            Console.WriteLine("Please enter group max Student");
                            string maxstudent = Console.ReadLine();
                           bool maximum= int.TryParse(maxstudent, out int max);
                            if (maximum == false)
                            {
                                Console.WriteLine("please enter correctly max count");   
                            }
                            else
                            {
                                Group group = new Group(groupname, max);
                                if (!groups.Contains(group))
                                {
                                    groups.Add(group);
                                }
                                else
                                {
                                    Console.WriteLine("There is group already with this name");
                                }                                  
                            }    
                        }    
                   Console.WriteLine("Group lists");
                    foreach (Group item in groups)
                        {
                            //Console.WriteLine("All group list");
                            Console.WriteLine(item);
                     }
                }
                else if (result == 2)
                {
                        if (groups.Count <1)
                        {
                            Console.WriteLine("Please enter the group first");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Please enter student name");
                            string studname = Console.ReadLine();
                            Console.WriteLine("Please enter student surname");
                            string studsurname = Console.ReadLine();
                            Student st = new Student(studname, studsurname);
                            Console.WriteLine("Please enter student group id");

                            bool groupId= int.TryParse(Console.ReadLine(), out int groupid);
                        
                            if (groupId == true)
                            {
                                for (int i = 1; i <=groups.Count; i++)
                                {                                    
                                   if (groups[i-1].id == groupid)
                                    {
                                        if (groups[i-1].MaxStudentCount > groups[i-1].studentCount)
                                        {
                                            groups[i-1].addStudent(st);
                                            groups[i-1].studentCount++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("It is not possible because capasity is not enough!!!");
                                        }
                                    }
                                    //else
                                    //{
                                    //    Console.WriteLine("There is not group with this id.");
                                    //}                            
                                }
                                foreach (var item in groups)
                                {
                                    Console.WriteLine(item);
                                }
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("please enter correct id.");
                                break;
                            }       
                        }
                }
                else if (result == 3)
                    {
                        Console.WriteLine("Please enter student mark");
                        bool res1 = int.TryParse(Console.ReadLine(), out int mark);
                        Console.WriteLine("Please enter student id");
                        bool idmark = int.TryParse(Console.ReadLine(), out int id);
                        if (res1 == true &&idmark==true)
                        {
                            if (mark <= 100 && mark > 0)
                            {
                                for (int i = 0; i < groups.Count; i++)
                                {
                                    foreach (var item in groups[i].students)
                                    {
                                        if (item.id == id)
                                        {
                                            item.addMark(mark);
                                            Console.WriteLine(item + "," + " Mark=" + mark.ToString());
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Number must be less than 100 and more than 0");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Id and Mark must be number");
                        }
                    }
                else if(result==4)
                    {
                        for (int i = 0; i < groups.Count; i++)
                        {
                            foreach (var item in groups[i].students)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                else if (result == 5)
                    {
                        Console.WriteLine("Please enter students name or surname");
                        string findword = Console.ReadLine();
                        if (groups.Count > 0)
                        {
                            for (int i = 0; i < groups.Count; i++)
                            {
                                foreach (var item in groups[i].students)
                                {
                                    if (item.Name.Contains(findword) || item.Surname.Contains(findword))
                                    {
                                        Console.WriteLine(item + " GroupName= " + groups[i].Name);
                                    }
                                    else
                                    {
                                        Console.WriteLine("There is not user with this id!!!");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is not user completely.Users count=0");
                        }
                    }
                else if (result == 6)
                    {
                        Console.WriteLine("Enter the group id");
                        bool booldelete=int.TryParse(Console.ReadLine(),out int deleteId);
                        if (booldelete == true)
                        {
                            int count = groups.Count;
                            if (groups.Count>0)
                            {
                                for (int i = 1; i <=count; i++)
                                {
                                    if (groups[i-1].id == deleteId)
                                    {
                                        groups.Remove(groups[i-1]);
                                        Console.WriteLine("Group lists");
                                        foreach (Group item in groups)
                                        {
                                            //Console.WriteLine("All group list");
                                            Console.WriteLine(item);
                                        }
                                    }
                                    //else
                                    //{
                                    //    Console.WriteLine("There is not group with this id.");
                                    //}
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is not group.Group count is zero");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Id must be number. Enter correctly.");
                        }
                       
                    }
            }
           else if (number=="exit")
                {
                    Console.WriteLine("Do you want to exit:Yes :NO");
                    string quit = Console.ReadLine().ToLower();
                    if (quit=="yes")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        continue;
                    }
                }
           else if (result > 6)
                {
                    Console.WriteLine("Menu number must be less than 7");
                }
            else
            {
                Console.WriteLine("Please enter  the number!!!");
            }
            }
        }
    }
}
