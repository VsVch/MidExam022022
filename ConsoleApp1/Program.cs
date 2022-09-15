using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string inputComands = string.Empty;
            while ((inputComands = Console.ReadLine()) != "Done")
            {

                string[] comand = inputComands.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine(string.Join(" ", comand));

                Console.WriteLine(string.Join(" ", comand));

                switch (comand[0])
                {
                    case "Add Book":
                        input.Add(comand[1]);
                        Console.WriteLine($"ioiooiooi");
                        break;
                    case "Take Book":
                        input.Remove(comand[1]);
                        break;
                    case "Swap Books":

                        string lessonTitle1 = comand[1];
                        string lessonTitle2 = comand[2];
                        int index1 = input.IndexOf(lessonTitle1);
                        int index2 = input.IndexOf(lessonTitle2);

                        if (input.Contains(lessonTitle1) && input.Contains(lessonTitle2))
                        {
                            string tempLessonTitle1 = input.ElementAt(index1);
                            input[index1] = input[index2];
                            input[index2] = tempLessonTitle1;
                        }

                        //if (input.Contains(lessonTitle1 + "-Exercise") && input.Contains(input[index1]))
                        //{
                        //    index1 = input.IndexOf(lessonTitle1);
                        //    input.Remove(lessonTitle1 + "-Exercise");
                        //    input.Insert(index1 + 1, lessonTitle1 + "-Exercise");
                        //}
                        //else if (input.Contains(lessonTitle2 + "-Exercise") && input.Contains(input[index2]))
                        //{
                        //    index2 = input.IndexOf(lessonTitle2);
                        //    input.Remove(lessonTitle2 + "-Exercise");
                        //    input.Insert(index2 + 1, lessonTitle2 + "-Exercise");
                        //}
                        break;
                    case "Insert Book":
                        input.Add(comand[1]);
                        break;
                    case "Check Book":


                        
                        int index = int.Parse(comand[1]);

                        if (index < 0 || index >= input.Count)
                        {
                            
                        }
                        else 
                        {
                            Console.WriteLine($"{input[index]}");
                        }
                        break;





                  
                    default:
                        break;
                }




            }

            Console.WriteLine(string.Join(" ", input));



                //StringBuilder result = new StringBuilder();
                //List<string> nonNumbers = new List<string>();
                //nonNumbers.AddRange(input);

                //string commands = string.Empty;

                //while ((commands = Console.ReadLine()) != "Done")
                //{
                //    string[] command = commands.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);



                //    string action = command[0];
                //    if (action == "Add Book ")
                //    {
                //        nonNumbers.Add(command[1]);
                //        Console.WriteLine(action[1]);


                //        Console.WriteLine(string.Join(" ", nonNumbers));
                //        Console.WriteLine();
                //    }
                //    else if (action == "Take Book ")
                //    {
                //        Console.WriteLine($"ooo");
                //    }
                //    else if (action == "Swap Books ")
                //    {
                //        Console.WriteLine($"ooo");
                //    }
                //    else if (action == "Insert Book ")
                //    {
                //        Console.WriteLine($"ooo");
                //    }
                //    else if (action == "Check Book ")
                //    {
                //        Console.WriteLine($"ooo");
                //    }

                //}

            }
    }
}







//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _10._SoftUni_Course_Planning
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> list = Console.ReadLine().Split(", ").ToList();
//            string input = string.Empty;
//            while ((input = Console.ReadLine()) != "course start")
//            {
//                string[] command = input.Split(":");

//                list = SoftUniCoursePlanning(list, command);
//            }

//            for (int i = 0; i < list.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}.{list[i]}");
//            }
//        }

//        static List<string> SoftUniCoursePlanning(List<string> list, string[] command)
//        {
//            switch (command[0])
//            {
//                case "Add": list = Add(list, command); break;
//                case "Insert": list = Insert(list, command); break;
//                case "Remove": list = Remove(list, command); break;
//                case "Swap": list = Swap(list, command); break;
//                case "Exercise": list = Exercise(list, command); break;
//                default:
//                    break;
//            }

//            return list;
//        }

//        static List<string> Exercise(List<string> list, string[] command)
//        {
//            string lessonTitle = command[1];

//            if (list.Contains(lessonTitle) && !list.Contains(lessonTitle + "-Exercise"))
//            {
//                int index = list.IndexOf(lessonTitle);
//                list.Insert(index + 1, lessonTitle + "-Exercise");
//            }
//            else if (!list.Contains(lessonTitle))
//            {
//                list.Add(lessonTitle);
//                list.Add(lessonTitle + "-Exercise");
//            }

//            return list;
//        }

//        static List<string> Swap(List<string> list, string[] command)
//        {
//            string lessonTitle1 = command[1];
//            string lessonTitle2 = command[2];
//            int index1 = list.IndexOf(lessonTitle1);
//            int index2 = list.IndexOf(lessonTitle2);

//            if (list.Contains(lessonTitle1) && list.Contains(lessonTitle2))
//            {
//                string tempLessonTitle1 = list.ElementAt(index1);
//                list[index1] = list[index2];
//                list[index2] = tempLessonTitle1;
//            }

//            if (list.Contains(lessonTitle1 + "-Exercise") && list.Contains(list[index1]))
//            {
//                index1 = list.IndexOf(lessonTitle1);
//                list.Remove(lessonTitle1 + "-Exercise");
//                list.Insert(index1 + 1, lessonTitle1 + "-Exercise");
//            }
//            else if (list.Contains(lessonTitle2 + "-Exercise") && list.Contains(list[index2]))
//            {
//                index2 = list.IndexOf(lessonTitle2);
//                list.Remove(lessonTitle2 + "-Exercise");
//                list.Insert(index2 + 1, lessonTitle2 + "-Exercise");
//            }

//            return list;
//        }

//        static List<string> Remove(List<string> list, string[] command)
//        {
//            string lessonTitle = command[1];

//            if (list.Contains(lessonTitle))
//            {
//                list.Remove(lessonTitle);
//            }
//            else if (list.Contains(lessonTitle + "-Exercise"))
//            {
//                list.Remove(lessonTitle + "-Exercise");
//            }

//            return list;
//        }

//        static List<string> Insert(List<string> list, string[] command)
//        {
//            string lessonTitle = command[1];
//            int index = int.Parse(command[2]);

//            if (index < 0 || index >= list.Count)
//            {
//                return list;
//            }
//            else if (!list.Contains(lessonTitle))
//            {
//                list.Insert(index, lessonTitle);
//            }

//            return list;
//        }

//        static List<string> Add(List<string> list, string[] command)
//        {
//            string lessonTitle = command[1];

//            if (!list.Contains(lessonTitle))
//            {
//                list.Add(lessonTitle);
//            }

//            return list;
//        }
//    }
//}