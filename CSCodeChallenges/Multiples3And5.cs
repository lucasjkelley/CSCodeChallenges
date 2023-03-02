namespace CSCodeChallenges
{
    internal class Multiples3And5
    {
        static void Main(string[] args)
        {
            /*
             *  - if we list all natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6,and 9. 
             *  the sum of these numbers is 23.
             *  - Find the sum of all multiples of 3 or 5 below 1000 and print it to the console.
             */

            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of all multiples of 3 and 5 below 1000 is: {sum:n0}");

        }
    }
}