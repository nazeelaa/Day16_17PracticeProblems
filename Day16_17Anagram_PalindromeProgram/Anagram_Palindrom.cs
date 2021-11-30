using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_17Anagram_PalindromeProgram
{
    class Anagram_Palindrom
    {
        public static void IsPrime()
        {
            int min = 0, max = 1000;
            string[] primeList = new string[175];
            int count = 0;
            Console.Write("\n List of Palindrome Prime  numbers : ");
            while (min < max)
            {
                int i = 2, isprime = 1, limit = (min + 1 / 2);

                if (min <= 2)
                {
                    isprime = 0;
                }
                while (i < limit)
                {
                    int check = min % i;
                    if (check == 0)
                    {
                        isprime = 0;
                        break;
                    }
                    i++;
                }

                if (isprime == 1)
                {
                    primeList[count] = Convert.ToString(min);
                    count++;
                    int next = min, remainder, reverse = 0;
                    while (next > 0)
                    {
                        remainder = next % 10;
                        reverse = reverse * 10 + remainder;
                        next /= 10;
                    }
                    if (min == reverse)
                    {
                        Console.Write("  " + min);
                    }
                }
                min++;
            }

            Console.Write("\n\n List of anagram prime numbers : ");

            foreach (var x in primeList)
            {
                foreach (var y in primeList)
                {
                    if (x == null || y == null)
                    {
                        break;
                    }
                    char[] num1 = x.ToCharArray();
                    char[] num2 = y.ToCharArray();
                    Array.Sort(num1);
                    Array.Sort(num2);
                    string splited1 = new string(num1);
                    string splited2 = new string(num2);
                    if (splited1 == splited2 && x != y)
                    {
                        Console.Write(" {0} , {1} \t", x, y);
                    }
                }
            }
        }
    }
}
