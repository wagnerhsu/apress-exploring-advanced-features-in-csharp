using System;
using System.Collections;
using System.Linq;
using MoreLinq;

namespace PatternMatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PatternIfTest();
        }
        public static void PatternIfTest()
        {
            ExchangeStudent exchStudent = new ExchangeStudent(("John", "Doe", 21), UniversityCourses.Maths, DateTime.Now.AddMonths(6));
            Student student = new Student(("Mark", "Bates", 23), 12345, UniversityCourses.Chemistry);
            Lecturer lecturer = new Lecturer(("Allan", "Johnson", 35), 54321, UniversityCourses.Anatomy, DateTime.Now.AddYears(-3));
            Alumnus alumnus = new Alumnus(("Gabby", "Salinger", 26), 2017, UniversityDegree.BSc);
            Alumnus senalumnus = new Alumnus(("Frank", "Greer", 74), 1970, UniversityDegree.BSc);
            System.Collections.ArrayList all = new ArrayList {
                exchStudent,student,lecturer,alumnus,senalumnus
            };
            all.OfType<object>().ForEach(x => Console.WriteLine(GetPersonCourse(x)));
            string GetPersonCourse(object someperson)
            {
                if (someperson is Student student)
                {
                    return $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
                }
                else if (someperson is Lecturer lecturer)
                {
                    return $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
                }
                else if (someperson is Alumnus alumnus)
                {
                    return $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
                }
                else if (someperson is ExchangeStudent exchStudent)
                {
                    return $"{exchStudent.ExchangeStudentDetails().fullName} has {exchStudent.ExchangeStudentDetails().daysLeftOnVisa} days left on Student Visa";
                }
                else
                    return string.Empty;
            }
        }

        static string GetPersonCourseUsingPatternMatchingSwitch(object someperson)
        {
            switch (someperson)
            {
                case Student student:
                    return $"{student.StudentDetails().fullName}";
                case Lecturer lecturer:
                    return $"{lecturer.LecturerDetails().fullName}";
                case Alumnus alumnus:
                    return $"{alumnus.AlumnusDetails().fullName}";
                case ExchangeStudent exchangeStudent:
                    return $"{exchangeStudent.ExchangeStudentDetails().fullName}";
                case null:
                    return $"{nameof(someperson)} cannot be null";
                default:
                    return string.Empty;
            }
        }
    }
}
