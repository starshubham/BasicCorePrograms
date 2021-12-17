using System;

namespace FlipCoin1
{
    class Program
    {
        static void Main(string[] args)
        {
            int head = 0;
            int tail = 0;

            Random rand = new Random();
            Console.WriteLine("Enter the total number of tosses you want: ");
            int userInput = Convert.ToInt32(Console.ReadLine()); // To convert string into integer

            int i = 0;
            while ( i < userInput )
            {
                int myKey = rand.Next(0, 2);
                if (myKey == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
                i++;
            }

            double resultHead = (head * 100) / userInput;
            double resultTail = (tail * 100) / userInput;

            Console.WriteLine("Percentage of Head  = " + resultHead + "%");
            Console.WriteLine("Percentage of Tail = " + resultTail + "%");
        }
    }
}
