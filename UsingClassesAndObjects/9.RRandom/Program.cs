using System;

namespace _9.RRandom
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();  // нова инстанция
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
                Random randBad = new Random();    // нова инстанция всеки път
                int randNum = randBad.Next(1000, 2000);
                Console.WriteLine(randNum);
            }

        }
    }
}
