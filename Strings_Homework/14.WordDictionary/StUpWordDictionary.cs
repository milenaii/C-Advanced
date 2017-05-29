using System;
using System.Collections.Generic;
/*A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
  .NET – platform for applications from Microsoft
  CLR – managed execution environment for .NET
  namespace – hierarchical organization of classes
 */
namespace _14.WordDictionary
{
    class StUpWordDictionary
    {
        static void Main()
        {
            var newDictionary = new Dictionary<string, string>()
            {
                { ".NET", "platform for applications from Microsoft" },
                { "CLR","managed execution enviroment for .NET" },
                { "namespace","hierarchical organizations of classes "}
            };

            Console.WriteLine("Enter a word from the dictionary: ");

            var input = Console.ReadLine();
            Console.WriteLine(newDictionary[input]); 

        }
    }
}
