using System;

namespace _8.Structures
{
    struct Pos
    {
        // специфичното при констр на стр-те, е че тр да се зададат ст-сти на вс членове:
        public Pos(int x, int y)
        {
            X = x;   // едните са с главни, др с малки букви за да ги различ 
            Y = y; 
        }

        public int X { get; set; }
        public int Y { get; set; }
    } 

    class Structures
    {
        static void Main(string[] args)
        {
            // нов обект от Pos
            Pos start = new Pos();
            start.X = 10;
            start.Y = 15;

            // ако искаме така:
            Pos arrPos = new Pos(10, 15);  // ни трябва конструктор

            // можем да изп напр при двумерен масив за да го обхождаме
            // x, y - ред и колона, които да обхождаме

            arrPos.Y++;
            arrPos.X--;

            // и във всеки един момент да проверяваме къде смеМ

            Console.WriteLine("({0}, {1})", arrPos.X, arrPos.Y);  // (9,16)
        }
    }
}
