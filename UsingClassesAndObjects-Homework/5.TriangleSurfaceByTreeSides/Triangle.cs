using System;

namespace _5.TriangleSurfaceByTreeSides
{
    class Triangle
    {
        //method
        public double CalculateTriangleSurface(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC)/ 2;
            double surface = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return surface; 
        }

    }
}
