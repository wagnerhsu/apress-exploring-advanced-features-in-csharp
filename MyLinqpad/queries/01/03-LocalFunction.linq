<Query Kind="Program">
  <NuGetReference>morelinq</NuGetReference>
  <Namespace>MoreLinq</Namespace>
</Query>

#load "01\02-PatternMaching.-Common"

void Main()
{
	Cube cube = new Cube(5);
	Pyramid pyramid = new Pyramid(5, 5, 5);
	Sphere sphere = new Sphere(5);
	Student student = new Student(("john", "doe", 22), 12345, UniversityCourses.Anatomy);
	System.Collections.ArrayList all = new ArrayList{
		cube,student,pyramid,sphere
	};
	all.OfType<object>().ForEach(x =>
	{
		LocalFunctionExample lfe = new LocalFunctionExample(x);
		Console.WriteLine($"This is a {lfe.ObjectType} with a volume of {lfe.ObjectVolume}");
	});
	
}

// Define other methods and classes here
public class Cube
{
	public double Edge { get; }
	public Cube(double edgeLength)
	{
		Edge = edgeLength;
	}
}

public class Pyramid
{
	public double BaseLength { get; }
	public double BaseWidth { get; }
	public double Height { get; }
	public Pyramid(double triangleBaseLength, double triangleBaseWidth, double triangleHeight)
	{
		BaseLength = triangleBaseLength;
		BaseWidth = triangleBaseWidth;
		Height = triangleHeight;
	}
}

public class Sphere
{
	public double Radius { get; }
	public Sphere(double circleRadius)
	{
		Radius = circleRadius;
	}
}

public class LocalFunctionExample
{
	public double ObjectVolume { get; }
	public string ObjectType { get; }

	public LocalFunctionExample(object shapeObject)
	{
		//// We can call this here at the beginning, or at the end
		//ObjectVolume = GetObjectVolume(shapeObject);
		double GetObjectVolume(object shape)
		{
			switch (shape)
			{
				case Cube square:
					return Math.Pow(square.Edge, 3.00);
				case Pyramid triangle:
					return (triangle.BaseLength * triangle.BaseWidth * triangle.Height) / 3;
				case Sphere sphere:
					return 4 * Math.PI * Math.Pow(sphere.Radius, 3) / 3;
				case null:
					return 0.0;
			}

			return 0.0;
		}

		ObjectVolume = GetObjectVolume(shapeObject);
		ObjectType = ObjectVolume == 0.0 ? "Invalid Object Shape" : shapeObject.GetType().Name;
	}

}