using System;

namespace Methods_Homework
{
    class SayHellooo
    //Write a method that asks the user for his name and prints Hello, <name>!. 
    //Write a program to test this method.
    {

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);

        }

        static void Main()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            SayHello(name);
        }
    }
}
