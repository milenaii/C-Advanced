using System;

namespace UsingClassesAndObjects
{
    class ClassCat
    {
        static void Main()
        {
            //Тук мога да създам нова котка използвайки класа Cat, който е в др файл
            DateTime bDay = new DateTime(1998, 3, 12);
            Cat cat = new Cat("MISHELOVKA", bDay);

            Console.WriteLine(Cat.NUM_OF_PAWS);
            Console.WriteLine("The cat's name is {0}.", cat.Name);
            Console.WriteLine("Cat {0} is {1} years old.", cat.Name, cat.Age);
            Console.WriteLine("Is {0} alive? {1}", cat.Name, cat.IsAlive);

            //името не ми излиза 
        }
    }
}
