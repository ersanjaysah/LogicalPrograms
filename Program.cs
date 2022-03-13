using System;

namespace P2_PerfectNumber
{
    public class Program
    {
       public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
           
            for (int i = 1; i<num; i++)
            {
                

                if(num%i==0)
                {
                     count=count+i;
                }
               

            }
            if (count == num)
            {

                Console.WriteLine("the number is perfect number "+count);
            }
            else
            {
                Console.WriteLine("the number is not a perfect number ");
            }
        }
    }
}
