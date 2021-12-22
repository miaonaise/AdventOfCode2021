using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AdventOfCode
{
    class Day1
    {
        public static List<int> depths = File.ReadAllLines(@"D:\src\myProject\AdventOfCode\AdventOfCode\Day1.txt").Select(int.Parse).ToList();

        public static int Part1()
        {
            int count = 0;
            for (int i = 1; i < depths.Count; i++)
            {
                if (depths[i] > depths[i - 1])
                {
                    count++;
                }
                
            }
            return count;
        }

        public static int Part2()
        {
            int count = 0;
            for (int i = 3; i < depths.Count; i++)
            {
                if (depths[i] > depths[i - 3])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
