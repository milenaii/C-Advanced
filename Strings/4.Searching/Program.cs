using System;
namespace _4.Searching
{
    class StartUp
    {
        static void PrintAllIndexes(string text, string searchValue)
        {
            int currentIndex = text.IndexOf(searchValue);
            while (currentIndex != -1) //докато намираш нещо 
            {
                Console.WriteLine(currentIndex);
                currentIndex = text.IndexOf(searchValue, currentIndex + 1);
            }
                

        }

        static void Main()
        {
            string sentence = "We prog like programming aaaand programming";
            // дава ни първото точно съвпадение

            int index = sentence.IndexOf("programming");

            int middle = sentence.Length / 2;
            int ind = sentence.IndexOf("programming", middle);//започни търсенето от средата

            //Console.WriteLine(index);
            PrintAllIndexes(sentence, "programming");
        }
    }
}
