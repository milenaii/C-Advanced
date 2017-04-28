using System;

namespace _4.TriangleSurfaceBySideAndAltitude
{
    class Triangle
    {
        //const
        public const double denom = 2;

        //fields
        //private double side;
        //private double altitude;

        //method
        public double CalculateArea(double side, double altitude)
        {
            double area = (side * altitude) / denom; 
            return area;
        }  
    }
}
