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

            string a = "0", b = "0", c = "0", d = "0", e = "0"; // The four numbers
            Console.WriteLine("The next four line are the values for a, b, c, and d");
            a =Console.ReadLine();
            b =Console.ReadLine();
            c =Console.ReadLine();
            d =Console.ReadLine();

            for (int i = 0; i <= 3; i++)
            {
                //***a, ***b, ***c, ***d, for each value of **a*, etc.
                string comb1 = a + b + c + d;
                string comb2 = a + b + d + c;
                string comb3 = a + c + b + d;
                string comb4 = a + c + d + b;
                string comb5 = a + d + b + c;
                string comb6 = a + d + c + b;

                combinations.Add(comb1); combinations.Add(comb2); combinations.Add(comb3); combinations.Add(comb4); combinations.Add(comb5); combinations.Add(comb6);
                // using System.Collections.Generic;

                e = d; d = c; c = b; b = a; a = e; // rotates the numbers

            }

            for (int j = 0; j <= 23; j++)
            {
                Console.WriteLine(combinations[j]);
                Console.ReadLine();
            }

        }
    }
}

// Used code from
// https://tools.withcode.uk/quickref/


// Homework Complete.