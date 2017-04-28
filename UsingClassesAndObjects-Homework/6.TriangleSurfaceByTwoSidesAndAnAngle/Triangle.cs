using System;

namespace _6.TriangleSurfaceByTwoSidesAndAnAngle
{
    class Triangle
    {
        //const 
        double denom = 2;

        //method
        public double CalculateSurface(double sideA, double sideB, double angleDegrees)
        {
            double surface = (sideA * sideB * Math.Sin(angleDegrees*Math.PI/180)/denom);
            return surface;
        }

    }
}
