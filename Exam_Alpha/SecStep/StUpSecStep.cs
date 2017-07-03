using System;

namespace SecStep
{
    class StUpSecStep
    {
        //static string MoveLetter(string fir, int x, int y)
        //{
        //    string res = "";

        //    for (int m = 0; m < fir.Length; m++)
        //    {
        //        for (int i = 0; i < x; i++)  // to x
        //        {
        //            res += fir[i];
        //        }
        //        for (int i = x; i < y-1; i++)   //between x & y
        //        {
        //            res += fir[i + 1];
        //        }

        //        res += fir[m];                // in y

        //        for (int i = y; i <= fir.Length - 1; i++)  // after y
        //        {
        //            res += fir[i];
        //        }
        //    }
        //    //Console.WriteLine(res);

        //    return res;
        //}

        static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            string fir = "abcd";

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < fir.Length; j++)
                {
                    if (fir[i] == alphabet[j])
                    {
                        int x = i;
                        int y = j + 1;
                        continue;

                        //MoveLetter(fir, x, y);
                    }

                }
            }

        }
    }
}
