using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = 0;
            if (input.Count > input1.Count)
            {
                max = input.Count;
            }
            else
            {
                max = input1.Count;
            }

            for (int i = 0; i < max; i++)
            {
                if (i >= input.Count)
                {
                    Console.Write($"{input1[i]} ");
                }
                else if (i >= input1.Count)
                {
                    Console.Write($"{input[i]} ");
                }
                else
                {
                    Console.Write($"{input[i]} {input1[i]} ");
                }
            }
        }
    }
}
