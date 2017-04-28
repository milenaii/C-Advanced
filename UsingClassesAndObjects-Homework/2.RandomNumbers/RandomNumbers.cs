using System;


namespace _2.RandomNumbers
{
    class RandomNumbersss
    {
        static void Main()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randNum = rand.Next(100, 200);
                Console.WriteLine(randNum);
            }
        }
    }
}

