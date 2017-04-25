using System;

namespace _9.RRandom
{
    class Random
    {
        static void Main()
        {
            System.Random rand = new System.Random();  // нова инстанция
            for (int i = 0; i < 10; i++)
            {
                int randNum = rand.Next(1000, 2000);
                Console.WriteLine(randNum);
            }

            Console.WriteLine();

            // тр инстанцията да се създава само веднъж - ако е в цикъла
            // ще получим еднакви числа - виж: 

            for (int i = 0; i < 10; i++)
            {
                System.Random randBad = new System.Random();    // нова инстанция всеки път
                int randNum = randBad.Next(1000, 2000);
                Console.WriteLine(randNum);
            }

        }
    }
}
