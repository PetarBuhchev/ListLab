using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.SumAdjacantEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            for (int i = 0; i < input.Count; i++) 
            {
                if (i == input.Count-1)
                {
                    break;
                }
                if (input[i] == input[i+1]) 
                {
                    input[i] += input[i + 1];
                    input.Remove(input[i+1]);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
