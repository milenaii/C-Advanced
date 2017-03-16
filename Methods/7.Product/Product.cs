using System;


namespace _7.Product
{
    class Producttt
    {
        static int Product(params int[] numbers)
        {
            int prod = 1;

            foreach (var n in numbers)
            {
                prod *= n;
            }
            return prod;
        }
        static void Main()
        {
            int p1 = Product(1, 2, 3);
            int p2 = Product(4, 5, 6, 7, 8);
            int p3 = Product(1, 2, 3, 4, 5, 6, 7, 8);
            int p4 = Product(new int[] { 1, 2, 3 }); // може да подадем масив
            int p5 = Product();  // празен масив

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);

        }
    }
}
