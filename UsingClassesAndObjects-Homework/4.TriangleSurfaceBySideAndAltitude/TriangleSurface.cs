using System;
//Write program that calculates the surface of a triangle by given 
//a side and an altitude to it.

namespace _4.TriangleSurfaceBySideAndAltitude
{
    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("Enter a side of triangle:");
            double sideTr = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an altitude of triangle:");
            double altitTr = double.Parse(Console.ReadLine());

            Triangle myNewTr = new Triangle();
            Console.WriteLine(myNewTr.CalculateArea(sideTr,altitTr));
        }
    }
}
