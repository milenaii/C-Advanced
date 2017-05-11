using System;
using System.Text;


namespace _18.StrBiuldObhojdane
{
    class StartUpObhojdane
    {
        static void Main()
        {
            StringBuilder vo = new StringBuilder("0123456789");

            for (int i = 0; i < vo.Length; i++)
            {
                Console.WriteLine(vo[i]);
            }

            vo[2] = '0';

            Console.WriteLine(vo);

        }
    }
}
