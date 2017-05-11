using System;

namespace _15.BuildingStrings
{
    class StartUpBuildingString
    {

        // така е бавно виж стинг билдер - 16 project
        static string Repeat(char c, int count)
        {
            string result = "";
            while (count > 0)
            {
                result += c;
                count--;
            }
            // 2 way 
            //for (int i = 0; i < count-1; i++)
            //{
            //    result += c;
            //}
            return result;

        }

        static void Main()
        {
            Console.WriteLine(Repeat('*',4000));
        }
    }
}
