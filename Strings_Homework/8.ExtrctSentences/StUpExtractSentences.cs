using System;
//Write a program that extracts from a given text all sentences containing given word.
namespace _8.ExtractSentences
{

    //не е готова - намира думата, ако не отговаря на условията, после не търси в същото изречение друга дума
    class StUpExtractSentences
    {
        static void Main()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();

            //First we divide the string on the different sequences by .Split()

            string[] sentences = text.Split('.'); // array of sentences

            string output = "";

            for (int i = 0; i < sentences.Length; i++)
            {
                //for (int j = 0; j < sentences[i].Length; j++)
                {
                    int w = sentences[i].IndexOf(word);

                    if (w != -1)
                    {
                        if ((sentences[i].Substring(w - 1, 1) == " ") &&
                             (sentences[i].Substring(w + word.Length, 1) == " "))
                        {
                            output = sentences[i];
                            Console.WriteLine(output);
                        }
                        //else
                        //{
                        //    string sub = sentences[i].Substring(w);
                        //    w = sub.IndexOf(word);
                        //    if ((sentences[i].Substring(w - 1, 1) == " ") &&
                        //     (sentences[i].Substring(w + word.Length, 1) == " "))
                        //    {
                        //        output = sentences[i];
                        //        Console.WriteLine(output);
                        //    }
                        //}

                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
