using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeChallenges
{
    internal class TenDigitFibonacci
    {
        static void Main(string[] args)
        {
            /*
             *   Fn-1 + Fn-2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.  F12 is the first term to contain 3 digits.
             *   
             *   What is the index of the first term in the Fibonacci sequence to contain 10 digits?
             */
            
            int sum = 3;
            int n1 = 1;
            int n2 = 1;
            int next = 0;

            while (next <= 1_100_000_000)
            {
                next = n2 + n1;
                if (next >= 1_000_000_000)
                {
                    Console.WriteLine($"The first 10 digit number in the Fibonacci Sequence is: {next:n0}.\nAnd it is in the {sum}th index.");
                }
                n1 = n2;
                n2 = next;
                sum++;
            }
            
        }
    }
}
