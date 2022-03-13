using System;

namespace P3_PrimeNumber
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int num = int.Parse(Console.ReadLine());
            Program.MyMethod(num);
        }

        public static void MyMethod(int num)
        {
            int i = 2;

            for (i = 2; i > 1; i++)
            {

                while (num % i == 0)
                {
                    Console.WriteLine("prime factors are= " + i);
                    num = num / i;
                }

            }
        }
    }
}

