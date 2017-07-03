using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] mi = input.Split(' ');

            string fir = "";

            for (int i = 0; i < mi.Length; i++)
            {
                for (int j = mi[i].Length - 1; i < mi[i].Length; i++)
                {
                    fir += mi[i].Length - 1;
                }
                Console.WriteLine(fir);

               // Console.WriteLine(string.Join(",", mi));
            }


        }
    }
}
