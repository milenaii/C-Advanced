using System;

namespace _5.TriangleSurfaceByTreeSides
{
    class TriangleSurfaceTreeSidesss
    {
        static void Main()
        {
            Console.WriteLine("Enter first side of triangle:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second side of triangle:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third side of triangle:");
            double c = double.Parse(Console.ReadLine());

            Triangle myTri = new Triangle();
            Console.WriteLine("{0:0.00}",myTri.CalculateTriangleSurface(a,b,c));
            //2 way print
            //Console.WriteLine("{0:F2}",myTri.CalculateTriangleSurface(a,b,c));
        }
    }
}
