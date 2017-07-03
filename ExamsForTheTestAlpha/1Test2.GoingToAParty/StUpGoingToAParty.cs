using System;

namespace _1Test2.GoingToAParty
{
    class StUpGoingToAParty
    {
        static void Main()
        {
            string directions = Console.ReadLine();

            int pos = 0;
            //string message = "";

            while ((pos >= 0) && (pos < directions.Length))
            {
                char ch = directions[pos];
                
                if (ch >= 97)
                {
                    pos += (ch - 97 + 1);
                }
                else if (ch <= 90)
                {
                    pos -= ch - 65 + 1;
                }
                else if (ch == '^')
                {
                  Console.WriteLine("Djor and Djano are at the party at {0}!", pos);
                    return;
                }
            }
            Console.WriteLine("Djor and Djano are lost at {0}!", pos);
        }
    }
}
