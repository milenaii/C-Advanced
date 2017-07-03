using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CatchExAndThrow
{
    class Program
    {
        static int ReadUserNumber()
        {
            var username = Console.ReadLine();

            try
            {
                return int.Parse(Console.ReadLine());
                //виж ако напишеш букви вместо число -> catch!!!
            }
            catch (FormatException ex)
            {

                throw new FormatException(ex.Message + $"cause by user {username}");
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter username and on the next line enter number:");
            ReadUserNumber();
        }
    }
}
