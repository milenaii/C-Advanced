using System;

namespace _6.TriangleSurfaceByTwoSidesAndAnAngle
{
    class TrSurfaceTwoSidesAngle
    {
        static void Main()
        {
            //input
            Console.WriteLine("Enter the first side of  the triangle: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first side of the triangle: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an angle of the triangle, in degrees: ");
            double c = double.Parse(Console.ReadLine());

            Triangle myTr = new Triangle();
            Console.WriteLine("{0:0.00 }", myTr.CalculateSurface(a, b, c));

        }
    }
}
