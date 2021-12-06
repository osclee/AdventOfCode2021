using Common;
using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = FileReader.LinesAsInt(@"input.txt");
            Console.WriteLine("\n\n\n#################\n");
            Part1(list);
            Console.WriteLine("\n");
            Part2(list);
            Console.WriteLine("\n#################\n\n\n");

        }

        private static void Part1(int[] list)
        {
            var previous = -1;
            var count = -1;
            foreach (var item in list)
            {
                if (item > previous) count++;
                previous = item;
            }

            Console.WriteLine($"Number of depth measurment increases = {count}");
        }

        private static void Part2(int[] list)
        {
            var previous = -1;
            var count = -1;
            for (var i = 0; i < list.Length - 2; i++)
            {
                var sum = list[i] + list[i + 1] + list[i + 2];
                if (sum > previous) count++;
                previous = sum;
            }

            Console.WriteLine($"Number of multi-depth measurment increases = {count}");
        }
    }
}
