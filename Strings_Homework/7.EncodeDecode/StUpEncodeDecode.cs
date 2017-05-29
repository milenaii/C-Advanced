using System;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc.When the last key character is reached, the next is the first.
namespace _7.EncodeDecode
{
    class StUpEncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string text = Console.ReadLine();

            Console.WriteLine("Enter a key: ");
            string key = Console.ReadLine();

            while (key.Length < text.Length)  //To make the length of the key same to                                     the text length or bigger
            {
                key += key;
            }

            string encode = EncriptingString(text, key);
            Console.WriteLine("The encrypted text is: {0}", encode);
        }

        private static string EncriptingString(string text, string key)
        {
            StringBuilder encode = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                encode.Append((char)(text[i] ^ key[i]));
            }
            return encode.ToString();
        }
    }
}
