using System;

namespace _6_QuotientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
			int x, y, q, r;
			Console.Write("Enter first number:");
			x = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number:");
			y = Convert.ToInt32(Console.ReadLine());

			q = x / y;
			r = x % y;

			Console.WriteLine("Quotient of the number is:" + q);
			Console.WriteLine("Remainder of the number is:" + r);
			Console.ReadKey();
		}
    }
}
