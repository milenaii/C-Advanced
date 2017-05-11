using System;



namespace _19.ToStringFormat
{
    class ToStringFormat
    {
        static void Main()
        {
            string[] formats = "D E C F X P".Split(' ');

            foreach (string f in formats)
            {
                Console.WriteLine("{0} -> {1}",f ,3245.ToString(f));
            }

        }
    }
}
