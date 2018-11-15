using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            GCD gcd = new GCD();
            Thread t = new Thread(new ThreadStart(gcd.ThreadMethod1));
            int res;
            t.Start();
            sw.Start();
            res = gcd.Algorithm2(10, 30);
            sw.Stop();
            Thread.Sleep(0);
            Console.WriteLine(res);
            Console.WriteLine(sw.Elapsed);
            t.Join();
            Console.ReadLine();
        }
    }
}
