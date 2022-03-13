using System;

namespace P4_ReverseNumber
{
    public class Program
    {
       public static void Main(string[] args)
        {
            int result = 0;
            int remainder;
            Console.WriteLine("enter your number");
            int num = int.Parse(Console.ReadLine());

            while (num!=0)
            {
                remainder=num % 10;
                result = result*10 + remainder;
                num = num / 10;
            }
            Console.WriteLine(result);
        }
    }
}
