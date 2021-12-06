using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Common
{
    public class FileReader
    {
        public static string[] LinesAsString(string filename)
        {
            var lines = new List<string>();

            var reader = new StreamReader($"{filename}");

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines.ToArray();
        }

        public static int[] LinesAsInt(string filename)
        {
            return LinesAsString(filename).Select(int.Parse).ToArray();
        }
    }
}
