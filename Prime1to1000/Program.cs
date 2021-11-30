using System;

namespace Prime1to1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Start Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            int num2 = int.Parse(Console.ReadLine());
            
            for (int i =num1; i <= num2; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }

        }
    }
