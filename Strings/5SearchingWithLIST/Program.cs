using System;
using System.Collections.Generic;
namespace _4.Searching
{
    class StartUp
    {
        static List<int> AllIndexes(string text, string searchValue)
        {
            List<int> indices = new List<int>(); 

            int currentIndex = text.IndexOf(searchValue);
            while (currentIndex != -1) //докато намираш нещо 
            {
                indices.Add(currentIndex);
                currentIndex = text.IndexOf(searchValue, currentIndex + 1);
            }

            return indices;
        }

        static void Main()
        {
            string sentence = "We prog like programming aaaand programming lijwdfi hd programming";
            // дава ни първото точно съвпадение

            int index = sentence.IndexOf("programming");

            int middle = sentence.Length / 2;
            int ind = sentence.IndexOf("programming", middle);//започни търсенето от средата

            //Console.WriteLine(index);
            Console.WriteLine(string.Join(", ", AllIndexes(sentence,"programming")));

            
        }
    }
}
