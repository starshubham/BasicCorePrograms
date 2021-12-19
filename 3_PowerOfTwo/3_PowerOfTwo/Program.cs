using System;

/*
Power of 2
a. Desc -> This program takes a command-line argument N and prints a table of the
powers of 2 that are less than or equal to 2^N.
b. I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
c. Logic -> repeat until i equals N.
 */

namespace _3_PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter range for finding power table") ;
            string n = Console.ReadLine();
            int num = int.Parse(n);

            if (num < 0 || num > 30)
            {
                Console.WriteLine("Please enter number between 0 to 30");
            }
            else
            {
                // Console.WriteLine("Power of 2^" + num + " is: " + (Math.Pow(2, num)));
                Console.WriteLine();
                Console.WriteLine("Printing all till Power Value " + num);


                for (int i = 0; i <= num; i++)
                {
                    Console.WriteLine("Power of 2^" + i + " is: " + (Math.Pow(2, i)));
                }
            }
            
            
        }
    }
}
