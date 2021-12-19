using System;

/*
Factors
a. Desc -> Computes the prime factorization of N using brute force.
b. I/P -> Number to find the prime factors
c. Logic -> Traverse till i*i <= N instead of i <= N for efficiency.
d. O/P -> Print the prime factors of number N.
 */

namespace _5_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
            int i = 2;
            while (userInput > 1)
            {
                while (userInput % i == 0)
                {
                    Console.WriteLine(i);
                    userInput = userInput / i;
                }

                i++;
            }
        }
    }
}
