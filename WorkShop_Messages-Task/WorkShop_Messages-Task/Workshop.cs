using System;
using System.Numerics;
//Joro and Gosho are very good friends. They love to talk and devise master
//plans for world domination. Yet, John the Evil wants to steal their ideas.
//So, they have built an encryption system for communication.
//The encryption system consists of adding or subtracting numbers in their
//GeorgeTheGreat numeral system.The GeorgeTheGreat numeral system has exactly 
//10 different digits and each digit consists of 3 chacters as follows:....

//calculate the result of the operation, by given two numbers in GeorgeTheGreat 
//numeral system and an operator (subtraction or addition)

namespace WorkShop_Messages_Task
{
    class Workshop
    {
        static string[] numSystem = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
        //field, в класа, за да може да се използва във всеки един метод без да тр 
        // да го прехвърлям като параметър

        static void Main()
        {
            //reading input
            string strOne = Console.ReadLine();
            string op = Console.ReadLine();
            string strTwo = Console.ReadLine();

            //methods
            BigInteger numOne = Decrypt(strOne);
            BigInteger numTwo = Decrypt(strTwo);

            BigInteger numResult = (op == "+" ? numOne + numTwo : numOne - numTwo); 
            //sum or substract

            string result = Encrypt(numResult);
            Console.WriteLine(result);
        }

        private static BigInteger Decrypt(string str) // mar kon cyk yan ogi 
        {
            BigInteger result = 0;

            string digit; // като го инициализираме тук, ще имаме една 
                          // променлива, която ще преизползваме всеки път в цикъла
            for (int j = 0; j < str.Length; j += 3)
            {
                digit = str.Substring(j, 3); // string digit... ако иниц тук, вс път
                // при въртене ще иниц нова променлива - малко по-бавно
                for (int i = 0; i < numSystem.Length; i++)
                {
                    if (digit == numSystem[i])
                    {
                        result = result * 10 + i;
                    }
                }
            }
            return result;
        }

        private static string Encrypt(BigInteger num)
        {
            string result = "";

            int digit = 0;
            while (num > 0)
            {
                digit = (int)(num % 10);
                result = numSystem[digit] ;
                num /= 10;
            }

            return result;
        }

    }
}
