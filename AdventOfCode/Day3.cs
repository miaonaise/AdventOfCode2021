using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AdventOfCode
{
    class Day3
    {
        public static List<string> instructions = File.ReadAllLines(@"D:\src\myProject\AdventOfCode\AdventOfCode\Day3.txt").ToList();

        public static int Part1()
        {
            int product;
            string gamma = "";
            string epsilon = "";
            int gamma_decimal = 0;
            int epsilon_decimal = 0;

            var binary_length = instructions[1].Length;

            int[] diff = new int[binary_length];

            foreach (var binary in instructions)
            {
                for (int i = 0; i < binary_length; i++)
                {
                    if (binary[i] == '0')
                    {
                        diff[i]--;
                    }
                    else
                    {
                        diff[i]++;
                    }
                }
            }
            for (int i = 0; i < binary_length; i++)
            {
                if (diff[i] > 0)
                {
                    gamma += "1";
                    epsilon += "0";
                }
                else
                {
                    gamma += "0";
                    epsilon += "1";
                }
            }

            gamma_decimal = Convert.ToInt32(gamma, 2);
            epsilon_decimal = Convert.ToInt32(epsilon, 2);
            product = gamma_decimal * epsilon_decimal;

            return product;
        }
        public static int Part2()
        {
            int life_support_rating;
            int oxygen_generator_rating;
            int CO2_scrubber_rating;


            var oxygen_list = instructions;
            int current_pos = 0;
            while (oxygen_list.Count > 1)
            {
                var one_list = GetBinaries(oxygen_list, '1', current_pos);
                var zero_list = GetBinaries(oxygen_list, '0', current_pos);
                if (one_list.Count >= zero_list.Count)
                {
                    oxygen_list = one_list;
                }
                else
                {
                    oxygen_list = zero_list;
                }
                current_pos++;
            }

            var CO2_list = instructions;
            current_pos = 0;
            while (CO2_list.Count > 1)
            {
                var one_list = GetBinaries(CO2_list, '1', current_pos);
                var zero_list = GetBinaries(CO2_list, '0', current_pos);
                if (zero_list.Count <= one_list.Count)
                {
                    CO2_list = zero_list;
                }
                else
                {
                    CO2_list = one_list;
                }
                current_pos++;
            }

            oxygen_generator_rating = Convert.ToInt32(oxygen_list[0], 2);
            CO2_scrubber_rating = Convert.ToInt32(CO2_list[0], 2);

            life_support_rating = oxygen_generator_rating * CO2_scrubber_rating;

            return life_support_rating;
        }

        public static List<string> GetBinaries(List<string> original_list, char filter, int position)
        {
            List<string> filtered_list = new List<string> { };

            foreach (var binary in original_list)
            {
                if (binary[position] == filter)
                {
                    filtered_list.Add(binary);
                }
            }
            return filtered_list;
        }
    }
}
