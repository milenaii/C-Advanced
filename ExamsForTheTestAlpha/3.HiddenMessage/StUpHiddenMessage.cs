using System;
namespace _3.HiddenMessage
{
    class StUpHiddenMessage
    {
        static void Main()
        {
            string indStr = Console.ReadLine();
            string hiddenMessage = "";

            while (indStr != "end")
            {
                int ind = int.Parse(indStr);
                int step = int.Parse(Console.ReadLine());
                string line = Console.ReadLine();
                // до тук четем трите реда, тр да ги обработим

                if (ind < 0)
                {
                    ind = line.Length - ind; // ind += line.Length;
                }

                for (; ind < line.Length && ind >= 0; ind += step)
                {
                    hiddenMessage += line[ind];
                }

                //преди да завъртим нов цикъл, тр да прочетем още един ред - дали е end
                indStr = Console.ReadLine();
            }
            Console.WriteLine(hiddenMessage);

        }
    }
}