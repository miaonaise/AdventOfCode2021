using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AdventOfCode
{
    class Day2
    {
        public static List<string> instructions = File.ReadAllLines(@"D:\src\myProject\AdventOfCode\AdventOfCode\Day2.txt").ToList();

        public static int Part1()
        {
            int product;
            int depth = 0;
            int horizontal = 0;

            for (int i = 0; i < instructions.Count; i++)
            {
                string[] line = instructions[i].Split(' ');

                string text = line[0];
                int num = Convert.ToInt32(line[1]);

                switch(text)
                {
                    case "forward":
                        horizontal += num;
                        break;
                    case "up":
                        depth -= num;
                        break;
                    case "down":
                        depth += num;
                        break;
                    default:
                        Console.WriteLine("something aint right");
                        break;
                }

            }
            product = depth * horizontal;

            return product;
        }
        public static int Part2()
        {
            int product;
            int depth = 0;
            int horizontal = 0;
            int aim = 0;

            for (int i = 0; i < instructions.Count; i++)
            {
                string[] line = instructions[i].Split(' ');

                string text = line[0];
                int num = Convert.ToInt32(line[1]);

                switch (text)
                {
                    case "forward":
                        horizontal += num;
                        depth += aim * num;
                        break;
                    case "up":
                        aim -= num;
                        break;
                    case "down":
                        aim += num;
                        break;
                    default:
                        Console.WriteLine("something aint right");
                        break;
                }

            }
            product = depth * horizontal;

            return product;
        }
    }
}
