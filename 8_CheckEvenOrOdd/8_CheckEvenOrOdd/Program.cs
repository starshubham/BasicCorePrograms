using System;

namespace _8_CheckEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the Number :");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("{0} is Even Number", number);
            else
                Console.WriteLine("{0} is Odd Number", number);
        }
    }
}
