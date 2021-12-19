using System;

/*
Harmonic Number
a. Desc -> Prints the Nth harmonic number: 1/1 + 1/2 + ... + 1/N
(http://users.encs.concordia.ca/~chvatal/notes/harmonic.html).
b. I/P -> The Harmonic Value N. Ensure N != 0
c. Logic -> compute 1/1 + 1/2 + 1/3 + ... + 1/N
d. O/P -> Print the Nth Harmonic Value.
 */

namespace _4_HarmonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            double n = int.Parse(Console.ReadLine());
            double harmonicNumber = 0;

            for (double i = 1; i <= n; i++)
            {
                harmonicNumber += (1 / i);
                Console.WriteLine("1/" + i + "=" + (1 / i));
            }
            Console.WriteLine(" The " + n + " harmonic number is=" + harmonicNumber);
        }
    }
}
