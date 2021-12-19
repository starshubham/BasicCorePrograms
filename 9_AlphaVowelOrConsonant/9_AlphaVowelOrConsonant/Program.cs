using System;

/*
 * C# Program to Check Whether an Alphabet is Vowel or Consonant
 */

namespace _9_AlphaVowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            
            Console.Write("check whether the input alphabet is a vowel or not:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is Consonant");
                    break;
            }
        }
    }
}
