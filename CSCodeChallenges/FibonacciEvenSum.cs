using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeChallenges
{
    internal class FibonacciEvenSum
    {
        static void Main(string[] args)
        {
            /*
             * Using the Fibonacci sequence, find the sum of the even valued terms.
             * 
             * starting with 1 & 2, the first 10 terms will be:
             *      1,2,3,5,8,13,21,34,55,89
             */

            int sum = 2;
            int n1 = 1;
            int n2 = 2;
            int next = 0;

            while (sum < 4_000_000)
            {
                next = n2 + n1;
                    if (next % 2 == 0)
                    {
                        sum += next;
                    }
                n1 = n2;
                n2 = next;
            }
            Console.WriteLine($"\nThe sum of all even values in the Fibonacci Sequence (up to 4mil) is: {sum:n0}\n\n");
        }
    }
}
