using System;
using System.Text;


namespace _17.BuilderReplaceRemove
{
    class StartUpReplaceRemove
    {
        static void Main()
        {
            StringBuilder build = new StringBuilder("Zdraveyte, az sym Bay Ivan i sum doshul na izpit.");

            build.Replace("izpit", "kupon");
            build.Remove(17, 4);

            Console.WriteLine(build);  

            // StrB is mutable, so it's ok
        }
    }
}
