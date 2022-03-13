using System;
using System.Diagnostics;
using System.Threading;

namespace P6_StartAndStopWatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter your number");
            int num = int.Parse(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + " \n");
            }

            stopwatch.Stop();
            Console.WriteLine($"Executiontime:{ stopwatch.ElapsedMilliseconds}sec");
            Console.WriteLine("Time Elapsed is :{0}",stopwatch.Elapsed);
            

        }
    }
}
