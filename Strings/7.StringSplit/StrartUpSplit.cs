using System;
using System.Linq;
//числа, разделени със спейс - да се намери сумата
namespace _7.StringSplit
{
    class StrartUpSplit
    {
        static void Main()
        {
            string numbers = "1 2 3 10 17 333 66";

            string[] separedNumbers = numbers.Split(' ');

            int sum = 0;
            foreach (string n in separedNumbers)
            {
                //Console.WriteLine(n);  // to see numbers
                sum += int.Parse(n);
            }
            Console.WriteLine(sum);

            //2 way
            //Console.WriteLine(
            //  numbers.Split(' ').Select(int.Parse).Sum());

            string numbers2 = "1 2 3       10 17   333 66";
            string[] separedNumbers2 = numbers2.Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);

            foreach (string num in separedNumbers2)
            {
                Console.WriteLine(num); 
            }
            


        }
    }
}
