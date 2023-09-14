using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.ListManipulationAdvanced
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
                    case "Contains":
                        int commandNumIndex1 = int.Parse(commands[1]);
                        bool result = input.Contains(commandNumIndex1);
                        if (result) { Console.WriteLine("Yes"); }
                        else { Console.WriteLine("No such number"); }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 0)
                            {
                                Console.Write($"{input[i]} ");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 1)
                            {
                                Console.Write($"{input[i]} ");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            sum += input[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        List<int> filtered = new List<int>();
                        int commandNumIndex2 = int.Parse(commands[2]);

                        if (commands[1] == "<")
                        {
                            filtered = input.FindAll(e => e < commandNumIndex2);
                        }
                        else if (commands[1] == ">") 
                        {
                            filtered = input.FindAll(e => e > commandNumIndex2);
                        }
                        else if (commands[1] == ">=")
                        {
                            filtered = input.FindAll(e => e >= commandNumIndex2);
                        }
                        else if (commands[1] == "<=")
                        {
                            filtered = input.FindAll(e => e <= commandNumIndex2);
                        }
                        Console.WriteLine(string.Join(" ", filtered));
                        for (int i = 0; i < filtered.Count; i++)
                        {
                            filtered.RemoveAt(i);
                            i = -1;
                        }
                        break;
                }
                for (int i = 0; i < commands.Count; i++)
                {
                    commands.RemoveAt(i);
                    i = -1;
                }
                commands = Console.ReadLine().Split().ToList();
            }
        }
    }
}
