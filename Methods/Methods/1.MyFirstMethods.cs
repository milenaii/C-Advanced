using System;

class MyFirstMethods
{
    static void PrintHello()
    {
        Console.WriteLine("Hello");
    }

    static void Print(string text) // text is parameter
    {
        Console.WriteLine(text);
    }

    static void Main(string[] args)
    {
        PrintHello();

        Print("Hei Pesho"); // даваме стойност на параметъра text
        Print("Hei Gosho"); // това ще се изпълни също с новата стойност на парам text
        PrintSomeTimes("MIMI", 10);

    }
    static void PrintSomeTimes(string mimi, int repeat)
    {
        for (int i = 0; i < repeat; i++)
        {
            Console.WriteLine(mimi);
        }
    }

}


