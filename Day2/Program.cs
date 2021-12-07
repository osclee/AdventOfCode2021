using System;
using Common;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = FileReader.LinesAsString(@"input.txt");
            Console.WriteLine("\n\n\n#################\n");
            Part1(input);
            Console.WriteLine("\n");
            Part2(input);
            Console.WriteLine("\n#################\n\n\n");

        }

        private static void Part1(String[] input)
        {
            var position = 0;
            var depth = 0;

            input.ToList().ForEach(e =>
            {
                var parsed = e.Split(" ");
                var value = Int32.Parse(parsed[1]);

                if (parsed[0].Equals("forward"))
                {
                    position += value;
                }
                else if (parsed[0].Equals("down"))
                {
                    depth += value;
                }
                else if (parsed[0].Equals("up"))
                {
                    depth -= value;
                }
            });

            Console.WriteLine($"Part 1 answer is {position * depth}");
        }

        private static void Part2(String[] input)
        {
            var position = 0;
            var depth = 0;
            var aim = 0;

            input.ToList().ForEach(e =>
            {
                var parsed = e.Split(" ");
                var value = Int32.Parse(parsed[1]);

                if (parsed[0].Equals("forward"))
                {
                    position += value;
                    depth += aim * value;
                }
                else if (parsed[0].Equals("down"))
                {
                    aim += value;
                }
                else if (parsed[0].Equals("up"))
                {
                    aim -= value;
                }
            });

            Console.WriteLine($"Part 2 answer is {position * depth}");
        }
    }
}
