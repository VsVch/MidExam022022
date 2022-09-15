using System;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            List<string> nonNumbers = new List<string>();
            nonNumbers.AddRange(input);

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "Done")
            }
        string[] command = commands.Split(new char[] { '|' }, StringSplitOptions.None);
        Console.WriteLine(string.Join(" ", command));


            }

}



        }
}
