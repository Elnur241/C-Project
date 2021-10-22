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
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu:1-Add group|2-Add student|3-Add student mark|4-View student list|5-Find student|6-Delete group|Exit-exit");
            while (true) {
              
                Console.ResetColor();

                string number = Console.ReadLine().ToLower();
             bool res= int.TryParse(number, out int result);
             if (res==true) 
             {
                if(result == 1)
                {
                    Console.WriteLine("Please enter group name:");
                       
                    string groupname = Console.ReadLine();
                        if (groupname.Length == 0)
                        {
                            Console.WriteLine(" group name must not be null");  
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
                                groups.Add(group);
                              
                            }    
                        }
                      
                   Console.WriteLine("Group lists");
                    foreach (Group item in groups)
                        {
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
                                int ise = 0;
                                for (int i = 0; i < groups.Count; i++)
                                {
                                    if (groups[i].id==groupid)
                                    {
                                     
                                        if (groups[i].MaxStudentCount >= groups[i].studentCount) 
                                        {
                                          
                                            groups[i].addStudent(st);
                                            ise++;
                                            groups[i].studentCount=ise;
                                          
                                        }
                                        else
                                        {
                                            Console.WriteLine("It is not possible because capasity is not enough!!!");
                                        }  
                                    }
                                }

                                foreach (var item in groups)
                                {
                                    //int ise = 0;
                                    //foreach (var students in item.students)
                                    //{
                                    //    ise++;
                                    //    item.studentCount = ise;
                                    //}

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
                        if (res1 == true)
                        {
                            if(mark<=100 &&mark>0){
                            Student.addMark(mark);
                                Console.WriteLine(mark);
                            }
                            else
                            {
                                Console.WriteLine("Number must be less than 100 and more than 0");
                                continue ;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter Number");
                        }
                    }
                else if(result==4)
                    {
                        foreach (var item in groups)
                        {
                            Console.Write(item.students);
                        }

                    }
                else if (result == 5)
                    {
                        Console.WriteLine("Please enter students name or surname");
                        string findword = Console.ReadLine();
                        foreach (var item in groups)
                        {
                            if (item.students.Contains(new Student(findword))==true)
                            {
                                Console.WriteLine("tapildi");
                            }
                            else
                            {
                                Console.WriteLine("there is not user  with this name.");
                            }
                        }

                    }
                else if (result == 6)
                    {
                        Console.WriteLine("Enter the group name");
                        string groupnamedelete = Console.ReadLine();
                        foreach (var item in groups)
                        {
                            if (item.Name==groupnamedelete)
                            {
                                groups.Remove(item);
                            }
                            else
                            {
                                Console.WriteLine("there is not group with this name.");
                            }
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
            else
            {
                Console.WriteLine("Please enter  the number!!!");
            }

            }

        }
    }
}
