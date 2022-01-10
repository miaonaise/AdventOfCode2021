using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AdventOfCode
{
    class Day4
    {
        public static List<string> input = File.ReadAllLines(@"D:\src\myProject\AdventOfCode\AdventOfCode\Day4.txt").ToList();
        public static List<int> bingo_numbers = input[0].Split(",").Select(Int32.Parse).ToList();

        public static List<Day4Board> boards = new List<Day4Board>();

  
        private static void InitializeBoard()
        {
            List<List<int>> board_array = new List<List<int>>();
            List<int> row;
            for (int i = 1; i < input.Count; i++)
            {
                if (string.IsNullOrEmpty(input[i]))
                {
                    board_array = new List<List<int>>();
                }
                else
                {
                    row = input[i].Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).Select(Int32.Parse).ToList();
                    board_array.Add(row);

                    if (board_array.Count == 5)
                    {
                        boards.Add(new Day4Board(board_array));
                    }
                }
            }
        }

        public static int Part1()
        {
            InitializeBoard();
            int product;
            int calling_number;
            int sum_of_final_unmarked = 0;
            int final_call = 0;

            bool winner = false;
            int k = 0;
            while (!winner)
            {
                calling_number = bingo_numbers[k];

                for (int i = 0; i < boards.Count; i++)
                {
                    boards[i].Mark(calling_number);

                    bool win = boards[i].Check_Win();
                    if (win)
                    {
                        sum_of_final_unmarked = boards[i].Sum_of_Unmarked();
                        winner = true;
                        final_call = calling_number;
                    }
                    
                }
                k++;

            }

            product = final_call * sum_of_final_unmarked;

            return product;
        }
        public static int Part2()
        {
            InitializeBoard();
            int product;
            int calling_number;
            int sum_of_final_unmarked = 0;
            int final_call = 0;

            bool[] winner = new bool[boards.Count];
            int k = 0;
            while (winner.Any(x=>x == false))
            {
                calling_number = bingo_numbers[k];

                for (int i = 0; i < boards.Count; i++)
                {
                    if (winner[i] == false)
                    {
                        boards[i].Mark(calling_number);
                        bool win = boards[i].Check_Win();
                        if (win)
                        {
                            sum_of_final_unmarked = boards[i].Sum_of_Unmarked();
                            winner[i] = true;
                            final_call = calling_number;
                        }
                    }
                }
                k++;

            }

            product = final_call * sum_of_final_unmarked;

            return product;
        }
    }
}
