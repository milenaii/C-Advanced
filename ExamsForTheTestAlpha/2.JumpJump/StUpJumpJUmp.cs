using System;

namespace _2.JumpJump
{
    class StUpJumpJUmp
    {
        static void Main()
        {
            string instr = Console.ReadLine();
            int pos = 0;

            string message = "Fell off the dancefloor at {0}!";

            //while (pos < 0 || pos < instr.Length)
            while (pos >= 0 && pos < instr.Length)
            {
                char ch = instr[pos];

                if (ch == '^')
                {
                    //Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", pos);
                    message = "Jump, Jump, DJ Tomekk kommt at {0}!";
                    break;
                }
                else if ((ch - '0') == 0)
                {
                    //Console.WriteLine("Too drunk to go on after {0}!", pos);
                    message = "Too drunk to go on after {0}!";
                    break;
                }
                else if ((ch - '0') % 2 == 0)
                {
                    pos += (ch - '0');
                }
                else if ((ch - '0') % 2 == 1)
                {
                    pos -= (ch - '0');
                }
            }
            Console.WriteLine(message, pos);
        }
    }
}



