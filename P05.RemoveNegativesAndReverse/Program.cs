using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < 0)
                {
                    input.Remove(input[i]);
                    i--;
                }
            }
            if (input.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            for (int i = input.Count-1; i >= 0; i--)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
