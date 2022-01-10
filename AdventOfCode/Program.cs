using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var row in Day3.instructions)
            //{
            //    Console.WriteLine(row);
            //}


            //string meh = "34 24 234 14";
            //List<string> testlist = new List<string>() { "42", "3", "124" };

            


            //List<string> input = File.ReadAllLines(@"D:\src\myProject\AdventOfCode\AdventOfCode\Day4.txt").ToList();
            //var lol = input[3].Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).Select(Int32.Parse).ToList();
            //foreach (var item in lol)
            //{
            //    Console.WriteLine(item);
            //}


            //for (int i = 1; i <16; i++)
            //{
            //    Console.WriteLine(input[i]);
            //    if (string.IsNullOrEmpty(input[i]))
            //    {
            //        Console.WriteLine("True");
            //    }
            //}
            Console.WriteLine(Day4.Part2());
        }
    }
}
