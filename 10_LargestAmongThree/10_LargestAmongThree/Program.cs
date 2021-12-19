using System;

// C# Program to Find the Largest Among Three Numbers

namespace _10_LargestAmongThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter the value of A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("A is Largest");
            else if (b > c)
                Console.WriteLine("B is Largest");
            else if (c > b)
                Console.WriteLine("C is Largest");
            else
                Console.WriteLine("All numbers are equal");

            Console.ReadKey();
        }
    }
}
