using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input.Count % 2 == 1)
                {
                    int max = input.Count/2 + 1;
                    if (i == max-1)
                    {
                        Console.Write(input[i]);
                        break;
                    }
                    else
                    {
                        Console.Write($"{input[i] + input[input.Count-1-i]} ");
                    }
                }
                else if (input.Count % 2 == 0)
                {
                    if (i == input.Count/2)
                    {
                        break;
                    }
                    else
                    {
                    Console.Write($"{input[i] + input[input.Count - 1 - i]} ");
                    }
                }
            }
        }
    }
}
