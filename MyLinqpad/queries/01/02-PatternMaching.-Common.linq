<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
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

public class Lecturer : Person
{
	public int EmployeeNumber { get; }
	public string CourseSpecialization { get; }
	public DateTime DateEmployed { get; }
	public Lecturer((string firstname, string lastname, int age) personDetails, int employeeNumber, UniversityCourses courseSpecialization, DateTime dateEmployed)
	{
		FirstName = personDetails.firstname;
		LastName = personDetails.lastname;
		Age = personDetails.age;
		EmployeeNumber = employeeNumber;
		CourseSpecialization = courseSpecialization.ToString();
		DateEmployed = dateEmployed;
	}

	public (string fullName, int employeeNum, string courseSpecial, int totalDayesEmployed) LecturerDetails()
	{
		double lengthOfServiceInDays = DateTime.Now.Subtract(DateEmployed).TotalDays;
		var lecturerDetails = ($"{FirstName} {LastName}", EmployeeNumber, CourseSpecialization, Convert.ToInt32(lengthOfServiceInDays));
		return lecturerDetails;
	}
}

public class Alumnus : Person
{
	public int YearCompleted { get; }
	public UniversityDegree DegreeObtained { get; }
	public Alumnus((string firstname, string lastname, int age) personDetails, int yearStudiesCompleted, UniversityDegree degreeObtained)
	{
		FirstName = personDetails.firstname;
		LastName = personDetails.lastname;
		Age = personDetails.age;
		YearCompleted = yearStudiesCompleted;
		DegreeObtained = degreeObtained;
	}

	public (string fullName, int yearCompleted, string degreeObtained) AlumnusDetails()
	{
		var alumnusDetails = ($"{FirstName} {LastName}", YearCompleted, DegreeObtained.ToString());
		return alumnusDetails;
	}
}

public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
}

public struct ExchangeStudent
{
	public string FirstName { get; }
	public string LastName { get; }
	public string ShortCourse { get; }
	public DateTime VisaExpiryDate { get; }

	public ExchangeStudent((string firstname, string lastname, int age) personDetails, UniversityCourses shortCourse, DateTime studentVisaExpiryDate)
	{
		FirstName = personDetails.firstname;
		LastName = personDetails.lastname;
		ShortCourse = shortCourse.ToString();
		VisaExpiryDate = studentVisaExpiryDate;
	}

	public (string fullName, string shortCourse, int daysLeftOnVisa) ExchangeStudentDetails()
	{
		double lenOfVisa = VisaExpiryDate.Subtract(DateTime.Now).TotalDays;

		var exchangeDetails = ($"{FirstName} {LastName}", ShortCourse, Convert.ToInt32(lenOfVisa));
		return exchangeDetails;
	}
}
public enum UniversityCourses { Maths, Chemistry, Anatomy, LifeSkills }
public enum UniversityDegree { BA, BSc }