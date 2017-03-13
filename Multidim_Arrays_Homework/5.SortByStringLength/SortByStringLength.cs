using System;
//You are given an array of strings. Write a method
//that sorts the array by the length of its elements 
//(the number of characters composing them).
class SortByStringLength
{
    static void Main()
    {
        string[] st = { "sdkjn", "sdl", "sdlj", "kjkejfkuwhf", "lkf", "wlkfj" };
        Array.Sort(st, (x, y) => x.Length.CompareTo(y.Length));
        foreach (string stri in st)
        {
            Console.WriteLine(stri);
        }

    }
}

