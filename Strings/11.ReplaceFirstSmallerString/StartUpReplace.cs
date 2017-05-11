using System;

namespace _11.ReplaceFirstSmallerString
{
    class StartUpReplace
    {
        static void Main()
        {
            string text = "This is script or vbscript or javascript";
            // we want to replace
            // script -> one
            //vbscrip -> krusha
            //javascript -> mliako

            //1 way
            string result1 = text.Replace("javascript", "mliako");
            result1 = result1.Replace("vbscript", "krusha");
            result1 = result1.Replace("script", "one");

            //2 way
            string result2 = text.Replace("javascript", "mliako")
                                 .Replace("vbscript", "krusha")
                                 .Replace("script", "one");


            Console.WriteLine(result1);
            Console.WriteLine(result2);

            //BadReplace - не започваме от най-дългия
            string resultBad = text.Replace("script", "one")  // резулт е str,може replace
                                   .Replace("vbscript", "krusha")
                                   .Replace("javascript", "mliako");
            Console.WriteLine(resultBad);

        }
    }
}
