using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SizeOfFile
{
    class Program
    {
        static void Main(string[] args)
        {
          StreamReader file = new StreamReader(@"..\..\input.txt");
          const string filename = @"../../input.txt";
          FileInfo info = new FileInfo(filename);
          long lenght = info.Length;
          Console.WriteLine($"size file :{lenght}");
          file.Close();
        }
    }
}
