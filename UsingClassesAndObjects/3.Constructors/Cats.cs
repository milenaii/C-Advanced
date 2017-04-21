using System;

namespace _3.Constructors
{
    // един клас може да има няколко конструктора, вс тр да са с името на метода
    class Cats
    {
        private int age;
        private int weight;
        private bool isAlive;

        // конструктор по дефолт - празен

        //public Cats()
        //{
        //   
        //}


        //1 constructor
        public Cats(string name)
        {
            Name = name;
        }

        //2 constructor
        public Cats(string name, int weight)
        {
            Name = name;
            weight = 10;
        }

        public string Name { get; set; }

    }
}
