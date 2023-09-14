using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split().ToList();

            while (commands[0] != "end") 
            {
                switch (commands[0])
                {
                    case "Add":
                        int commandNum = int.Parse(commands[1]);
                        input.Add(commandNum);
                        break;
                    case "Remove":
                        commandNum = int.Parse(commands[1]);
                        input.Remove(commandNum);
                        break;
                    case "RemoveAt":
                        commandNum = int.Parse(commands[1]);
                        input.RemoveAt(commandNum);
                        break;
                    case "Insert":
                        commandNum = int.Parse(commands[1]);
                        int commandNum1 = int.Parse(commands[2]);
                        input.Insert(commandNum1, commandNum);
                        break;
                }
                for (int i = 0; i < commands.Count; i++)
                {
                    commands.RemoveAt(i);
                    i = -1;
                }
                commands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
