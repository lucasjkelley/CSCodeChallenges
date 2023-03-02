using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeChallenges
{
    internal class LongestCollatz
    {
        static void Main(string[] args)
        {
            /*
             * n - > n/2 (WHEN n is even use this)
             * n - > 3n + 1 (WHEN n is odd use this)
             * 
             */

            List<int> longCollatz = new List<int>() { };

            int currentValue = 0;
            int collatzMax = 0;
            int collatzNum = 0;

            for (int i = 1; i <= 1000; i++)
            {
                currentValue = i;
                bool exit = false;
                do
                {
                    longCollatz.Add(currentValue);

                    if (currentValue == 1 || currentValue == 0)
                    {
                        exit = true;
                    }
                    if (currentValue % 2 == 0)
                    {
                        currentValue /= 2;

                    }
                    else if (exit != true)
                    {
                        currentValue = (currentValue * 3) + 1;
                    }

                } while (exit != true);

                if (longCollatz.Count > collatzMax)
                {
                    collatzMax = longCollatz.Count;
                    collatzNum = i;
                }

                //foreach (var item in longCollatz)
                //{
                //    Console.Write(item + "-> ");
                //}

                longCollatz.Clear();
            }
            Console.WriteLine($"The starting number of {collatzNum} produces the longest chain with {collatzMax} terms.");

        }
    }
}
