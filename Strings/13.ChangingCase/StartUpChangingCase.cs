using System;

namespace _13.ChangingCase
{
    class StartUpChangingCase
    {
        static void Main()
        {
            string str1 = "123String are fun?";
            string str2 = "ANOTHER STRING?";
            string str3 = "WHERE IS MY PIZZA?";

            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str2.ToLower());
                
            //1 буква да е главна, другите - малки
            string name = "kOnSTaNtiN";
            string firstLetter = name.Substring(0, 1);


            string rest = name.Substring(1);
            Console.WriteLine(firstLetter);
            Console.WriteLine(rest);
            string result = firstLetter.ToUpper() + rest.ToLower();
            Console.WriteLine(result);



            //може с char
            char firstLet = name[0];
            string res = char.ToUpper(firstLet) + rest.ToLower();
            Console.WriteLine(res);
        }
    }
}
