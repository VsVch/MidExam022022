using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            List<string> nonNumbers = new List<string>();
            nonNumbers.AddRange(input);

            string commands =string.Empty;

            while ((commands = Console.ReadLine()) != "Done")
            {
                string[] command = commands.Split(new char[] {'|' }, StringSplitOptions.None);
                Console.WriteLine(string.Join(" ", command));

                

            //    string action = command[0];
            //    if (action == "Add Book ")
            //    {
            //        nonNumbers.Add(command[1]);


            //        Console.WriteLine(string.Join(" ", nonNumbers));
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
            //Console.WriteLine(string.Join(" ", nonNumbers));

        }
    }
}
