using System;
//Write a method that adds two polynomials.Represent them as arrays of their
//coefficients.Write a program that reads two polynomials and prints their sum.
namespace _11.AddingPolynomials
{
    class AddingPolynomialsss
    {
        static int[] AddTwoPolynomials(int powerPol, int[] firPol, int[] secPol)
        {
            int[] result = new int[powerPol];

            for (int i = 0; i < powerPol; i++)
            {
                result[i] = firPol[i] + secPol[i];
                //Console.WriteLine(result[i]);
            }
            return result;
            ////////////////////не ми се отпечатва не знам защо
        }

        static int[] SubstractTwoPolynomials(int powerPol, int[] firPol, int[] secPol)
        {
            int[] result = new int[powerPol];

            for (int i = 0; i < powerPol; i++)
            {
                result[i] = firPol[i] - secPol[i];
                Console.WriteLine(result[i]);
            }
            return result;
            ////////////////////не ми се отпечатва не знам защо
        }



        static void Main()
        {
            Console.WriteLine("Enter the power of polynomials N: ");
            int n = int.Parse(Console.ReadLine());

            int[] firstPol = new int[n];
            int[] secondPol = new int[n];

            Console.WriteLine("Enter the coeficient of the first polynomial, separated by spaces: ");
            // ex: 7 2 3  -> 7 + 2x + 3x^2

            string[] input1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                firstPol[i] = int.Parse(input1[i]);
            }

            Console.WriteLine("Enter the coeficient of the second polynomial, separated by spaces: ");

            string[] input2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                secondPol[i] = int.Parse(input2[i]);
            }

            Console.WriteLine(AddTwoPolynomials(n, firstPol, secondPol));
            Console.WriteLine(  SubstractTwoPolynomials(n, firstPol, secondPol));
        }
    }
}
