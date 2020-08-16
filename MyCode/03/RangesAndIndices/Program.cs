using System;

namespace RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Dirk", "Jane", "James", "Albert", "Sally" };
            foreach (var name in names[1..^1])
            {
                Console.Write(name);
                Console.Write("\t");
            }
            Console.WriteLine();
            Range range = 1..4;
            foreach (var name in names[range])
            {
                Console.Write(name);
                Console.Write("\t");
            }
            Console.WriteLine();
            foreach (var name in names[1..4])
            {
                Console.Write(name);
                Console.Write("\t");
            }

        }
    }
}
