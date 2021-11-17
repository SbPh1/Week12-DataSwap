using System;
using System.IO;

namespace DataSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            string autumnFile = @"C:\Users\Monkey\samples\autumn.txt";
            string winterFile = @"C:\Users\Monkey\samples\winter.txt";

            string[] winterData = File.ReadAllLines(autumnFile);
            string[] autumnData = File.ReadAllLines(winterFile);

            File.WriteAllLines(autumnFile, autumnData);
            File.WriteAllLines(winterFile, winterData);
        }
    }
}
