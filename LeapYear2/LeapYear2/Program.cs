using System;

namespace LeapYear2
{
    class Program
    {
        static bool checkYear(int year)
        {
            // Return true if year is a multiple
            // of 4 and not multiple of 100.
            // OR year is multiple of 400.
            return (((year % 4 == 0) && (year % 100 != 0)) ||
                    (year % 400 == 0));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 4 digit year you want to check:");
            int year = Convert.ToInt32(Console.ReadLine());
            
            Console.Write(checkYear(year) ?year + " is Leap Year" 
                : year + " is not a Leap Year"); 
            /*
            Ternary operator --> ( expression ? a : b)
            if expression --> true then print 'a' 
                                   else print 'b'
             */
        }
    }
}
