using System;

namespace _20.StrinFormat
{
    class StringFormat
    {
        static void Main()
        {
            string template = "{0,10} loves {1}";  //заделят се 10 символа за всеки стринга

            Console.WriteLine(string.Format(template,"dog", "cat"));

            Console.WriteLine(string.Format(template, "pesho", "gosho"));

            Console.WriteLine(string.Format(template, "pesho", "beer"));

            string template2 = "{0,10} loves {1:X}";  

            Console.WriteLine(string.Format(template2, "gosho", 2345));
            string template3 = "{0,10} loves {1:F6}"; // взема 6 симв след дес запетая

            Console.WriteLine(string.Format(template3, "gosho", 2345.321654987956556));

            // date formating - ex
            Console.WriteLine("{0:yyyy.MM.d h:mm:s}", DateTime.Now);


        }




    }
}
