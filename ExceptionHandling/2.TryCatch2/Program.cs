using System;

namespace _2.TryCatch2
{
    class Program
    {
        static void Main()
        {
            int userAge;
            try
            {
                userAge = int.Parse(Console.ReadLine());
                //throw new FormatException();
                //throw new ExecutionEngineException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("You probably entered an invalid value!");
            }
            catch(ExecutionEngineException)
            {
                Console.WriteLine("We catch another exception");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Entered too big value");
            }
            Console.WriteLine("End");
            
        }
    }
}
