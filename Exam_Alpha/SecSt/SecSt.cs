using System;

namespace SecSt
{
    class SecSt
    {
        static string MoveLetter(string fir, int x, int y)
        {
            string res = "";
            if (y < fir.Length)
            {

                for (int m = 0; m < fir.Length; m++)
                {
                    for (int i = 0; i < x; i++)  // to x
                    {
                        res += fir[i];
                    }
                    for (int i = x; i < y - 1; i++)   //between x & y
                    {
                        res += fir[i + 1];
                    }

                    res += fir[m];                // in y

                    for (int i = y; i <= fir.Length - 1; i++)  // after y
                    {
                        res += fir[i];
                    }
                }
            }
            if (y >= fir.Length)
            {
///////////////////
            }

            Console.WriteLine(res);
            return res;
        }

        static void Main()
        {
            string fir = "abcd";

            int x = 0;

            for (int j = 0; j < fir.Length; j++)
            {
                switch (j)
                {
                    case 'a': x = 1; break;
                    case 'b': x = 2; break;
                    case 'c': x = 3; break;
                    case 'd': x = 4; break;
                    case 'e': x = 5; break;
                    case 'f': x = 6; break;
                    case 'g': x = 7; break;
                    case 'h': x = 8; break;
                    case 'i': x = 9; break;
                    case 'j': x = 10; break;
                    case 'k': x = 11; break;
                    case 'l': x = 12; break;
                    case 'm': x = 13; break;
                    case 'n': x = 14; break;
                    case 'o': x = 15; break;
                    case 'p': x = 16; break;
                    case 'q': x = 17; break;
                    case 'r': x = 18; break;
                    case 's': x = 19; break;
                    case 't': x = 20; break;
                    case 'u': x = 21; break;
                    case 'v': x = 22; break;
                    case 'w': x = 23; break;
                    case 'x': x = 24; break;
                    case 'y': x = 25; break;
                    case 'z': x = 26; break;
                    default:
                        break;
                }

                int y = j + x;
                MoveLetter(fir, x, y);
                //Console.WriteLine(MoveLetter(fir, x, y));
            }
        }
    }
}

