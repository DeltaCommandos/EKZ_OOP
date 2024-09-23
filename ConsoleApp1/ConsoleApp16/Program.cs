using System;
using System.Diagnostics;


public class Program
{
    public static void ListGenerate(int X)
    {
        int c = 0;
        Random rnd = new Random();
        int N = rnd.Next(10000000,15000000);
        int[] myList = new int[N];

        for (int i = 0; i < N; i++)
        {
            myList[i] = rnd.Next(0, 1000);
        }

        Array.Sort(myList);

        foreach (int item in myList)
        {
            if (item == X)
            {
                c++;
            }
        }


    }


    public static void Main(string[] args)
    {
        long MaxTime = long.MinValue;
        long MinTime = long.MaxValue;
        long Sum = 0;
        int x = 123;
        Thread[] threads = new Thread[10];
        object LockObj = new object();

        for (int i = 0;i<10;i++)
        {
            threads[i] = new Thread(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Restart();
                lock (LockObj)
                {
                    ListGenerate(x);
                    sw.Stop();
                }
                if (sw.ElapsedMilliseconds !=0)
                {
                    MinTime = Math.Min(MinTime, sw.ElapsedMilliseconds);
                    MaxTime = Math.Max(MaxTime, sw.ElapsedMilliseconds);
                    Sum += sw.ElapsedMilliseconds;

                }


            });
            threads[i].Start();
        }
        for (int i = 0; i<10;i++)
        {
            threads[i].Join();
        }

        double SrTime = Sum / 1000;
        Console.WriteLine("min = {0}, max = {1}, sredneye={2}", MinTime, MaxTime, SrTime);



    }



}