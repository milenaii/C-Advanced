using System;

namespace _12.Remove
{
    class StartUpRemove
    {
        static void Main()
        {
            string text = "muhata padna ot stola";

            //text.Remove(4);           не става защото стр не се променят !!!
            //Console.WriteLine(text);

            string result = text.Remove(15);
            string resultTwo = text.Remove(5, 3);
            Console.WriteLine(result);
            Console.WriteLine(resultTwo);


            //OTHER EXAMPLE
            // remove froM to

            string test = "0123456789ABCDEF";
                
            int from = 5;
            int to = 8;

            string resultTest = test.Remove(from, to - from);
            string resultTestTwo = test.Remove(from, to - from + 1);

            Console.WriteLine(resultTest);   //to се запазва
            Console.WriteLine(resultTestTwo);  // to  се изтрива

            //да вземем последните к символа от стринг:
            string bi = "abcdefjhijk";
            int k = 4;
            string res = bi.Substring(bi.Length - k);
            Console.WriteLine(res);



        }
    }
}
