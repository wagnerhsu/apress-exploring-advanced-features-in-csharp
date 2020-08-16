using System;

namespace DefaultLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = default;
            bool? blnValue = default;
            var bText = blnValue ?? false;
            Console.WriteLine($"{b},{bText}");
        }
    }
}
