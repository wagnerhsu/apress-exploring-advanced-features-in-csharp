namespace Common.Models
{
    public class Student : Person
    {
        public int StudentNumber { get; }
        public UniversityCourses CourseEnrolledFor { get; }
        public Student((string firstname, string lastname, int age) personDetails, int studentNumber, UniversityCourses courseEnrolled)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            StudentNumber = studentNumber;
            CourseEnrolledFor = courseEnrolled;
        }

        public (string fullName, int studentNum, string studentCourse) StudentDetails()
        {
            var studentDetails = ($"{FirstName} {LastName}", StudentNumber, CourseEnrolledFor.ToString());
            return studentDetails;
        }
    }
}