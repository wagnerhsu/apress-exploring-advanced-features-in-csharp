namespace Common.Models
{
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
}