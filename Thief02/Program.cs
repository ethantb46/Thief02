using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thief02
{
    class Program
    {
        static void Main()
        {
            /*
            * A thief has managed to find out the four digits for an online PIN code, but doesn't know the correct sequence needed to hack into the account.

Design and write a program that displays all the possible combinations for any four numerical digits entered by the user. The program should avoid displaying the same
combination more than once.

* https://live.withcode.uk/alevel/?id=3 **/

            List<string> combinations = new List<string>();

            string a, b, c, d = 0; // The four numbers
            Console.WriteLine("ALSKDJFLAKSJDHFL");
            for (int i = 0; i <= 3; i++)
            {
                //***a, ***b, ***c, ***d, for each value of **a*, etc.
                a + b + c + d
                a + b + d + c
                a + c + b + d
                a + c + d + b

                // using System.Collections.Generic;

                
            }

        }
    }
}

// Used code from
// https://tools.withcode.uk/quickref/
