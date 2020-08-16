using System;
using Common.Models;

namespace local_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube(5);
            Pyramid pyramid = new Pyramid(5, 5, 5);
            Sphere sphere = new Sphere(5);
            Student student = new Student(("john", "doe", 22), 12345, UniversityCourses.Anatomy);

            DisplayMessage(cube);
            DisplayMessage(pyramid);
            DisplayMessage(sphere);
            DisplayMessage(student); 
        }
        public static void DisplayMessage(object thing)
        {
            LocalFunctionExample lfe = new LocalFunctionExample(thing);
            Console.WriteLine($"This is a {lfe.ObjectType} with a volume of {lfe.ObjectVolume}");
        } 
    }
}
