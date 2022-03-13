using System;

namespace P5_CoupansProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter number you want: ");
            int num = int.Parse(Console.ReadLine());
            int[] random = new int[num];

            Console.WriteLine("Enter the Starting range of Random Number");
            int starting = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the ending range of Random numnber");
            int ending = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Random random1 = new Random();
                int n = random1.Next(starting, ending);
                random[i] = n;
            }
            Console.WriteLine("All Random Distinct Numbers are given below ");
            foreach (int a in random)
            {
                Console.WriteLine("Numbers are= "+a);
            }
        }
    }
}
