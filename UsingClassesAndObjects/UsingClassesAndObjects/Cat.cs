using System;


namespace UsingClassesAndObjects
{
    //класовете се пишат в отделен файл

    // в друг клас в същия namespace мога да създам нова котка
    class Cat
    {
        public const int NUM_OF_PAWS = 4; //конст - важи за всички котки!!
                                          // прието е да се пишат с големи буквии с долна черта

        public const int MAX_AGE = 15;

        private string name;
        // private int age;                //
        private int weight;             // това са field
        private bool hasTail;           //

        // constructor
        public Cat(string name, DateTime bDay)
        {
            Name = name;
            BirthDay = bDay;
        }

        //1 way property

        //        public string Name { get; set; } //това е готов темплейт за ползване
        // иначе е метод, който би могъл да изглежда така:

        //2 way property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // тук е удобно място за валидации,
                // затова е полезно да имаме property, а не само field
                if (string.IsNullOrEmpty(value))
                {
                    //throw Exception;
                }
                name = value;
            }
        }
        //another property
        public DateTime BirthDay { get; private set; }

        // метод в класа
        public void Eat(int calories)
        {
            weight = calories / 10;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDay.Year;
            }
        }
        public bool IsAlive
        {
            get
            {
                bool isAlive = true;
                if (Age > MAX_AGE)
                {
                    isAlive = false;
                }
                return isAlive;
            }
        }

    }
}
