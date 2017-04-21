using System;
// Copy from presentation  - I can't make it works
namespace PasswordGenerator
{
    class PasswordGenerator
    {
        static void Main()
        {
            StringBuilder password = new StringBuilder();
            for (int i = 1; i <= 2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                InsertAtRandomPos(password, capitalLetter);
            }
            for (int i = 1; i <= 2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPos(password, smallLetter);
            }
            char digit = GenerateChar(Digits);
            InsertAtRandomPos(password, digit);
            for (int i = 1; i <= 3; i++)
            {
                char specialChar = GenerateChar(SpecialChars);
                InsertAtRandomPos(password, specialChar);
            }
            int count = rnd.Next(8);
            for (int i = 1; i <= count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password, specialChar);
            }
            Console.WriteLine(password);
        }

        static void InsertAtRandomPos(StringBuilder password, char character)
        {
            int randomPosition = rnd.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }

        static char GenerateChar(string availableChars)
        {
            int randomIndex = rnd.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;

        }
    }
}
