using System;
using System.Text;

namespace SpellCasterr
{
    public class Spell
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] splittedInput = inputString.Split();

            int maxLength = 0;
            int counter = 0;
            int letterPosition = 0;

            for (int i = 0; i < splittedInput.Length; i++)
            {
                if (splittedInput[i].Length > maxLength)
                {
                    maxLength = splittedInput[i].Length;
                }
            }

            StringBuilder extractedLetters = new StringBuilder();

            while (true)
            {
                for (int i = 0; i < splittedInput.Length; i++)
                {
                    if (counter >= splittedInput[i].Length)
                    {
                        continue;
                    }
                    letterPosition = splittedInput[i].Length - counter - 1;
                    if (letterPosition >= 0)
                    {
                        extractedLetters.Append(splittedInput[i][letterPosition]);
                    }
                }
                counter++;
                if (counter == maxLength)
                {
                    break;
                }
            }

            int newPosition = 0;
            int listLength = extractedLetters.Length;

            for (int i = 0; i < extractedLetters.Length; i++)
            {
                char letter = extractedLetters[i];
                if (Char.IsLower(extractedLetters[i]))
                {
                    newPosition = extractedLetters[i] - 'a' + 1;
                }
                else
                {
                    newPosition = extractedLetters[i] - 'A' + 1;
                }
                extractedLetters.Remove(i, 1);
                newPosition += i;
                newPosition = newPosition % listLength;
                extractedLetters.Insert(newPosition, letter);
            }

            Console.WriteLine(extractedLetters.ToString());
        }
    }
}


