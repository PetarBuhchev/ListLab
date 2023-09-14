using System;
using System.Collections.Generic;

namespace P04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < num; i++) 
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i}.{products[i-1]}");
            }
        }
    }
}
