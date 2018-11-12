using System;
using System.Diagnostics;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            GCD gcd = new GCD();
            int res;
            sw.Start();
            res = gcd.Algorithm1(72,27);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.Elapsed);
            sw.Reset();
            sw.Start();
            res = gcd.Algorithm2(72, 27);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.Elapsed);      
            Console.ReadLine();
        }
    }
}
