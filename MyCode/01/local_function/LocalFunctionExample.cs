using System;
using Common.Models;

namespace local_function {
    public class LocalFunctionExample{
        public double ObjectVolume { get; }
        public string ObjectType { get; }
        public LocalFunctionExample(object shapeObject)
        {
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
}