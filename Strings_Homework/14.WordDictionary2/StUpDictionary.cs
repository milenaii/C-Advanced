using System;

namespace _14.WordDictionary2
{
    class StUpDictionary
    {
        static void Main()
        {
            string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes" };

            string word = "namespace";//Console.ReadLine();

            foreach (string line in dictionary)
            {
                if (line.IndexOf(word) == 0)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}