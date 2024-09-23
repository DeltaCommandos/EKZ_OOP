using System;
using System.Diagnostics;


public class Program
{
    public static int ListGenerate(int X)
    {
        int c = 0;
        Random random = new Random();
        int N = random.Next(10000000,15000000);
        int[] myList = new int[N];

        for (int i = 0; i < N; i++)
        {
            myList[i] = random.Next(0,1000);
            if(i%10000 == 0)
            {
                Console.WriteLine("Заполнен элемент №{0}",i);
            }
        }
        Array.Sort(myList);

        foreach(int item in myList)
        {
            if (item == X)
            {
                c++;
            }
        }
        return c;
    }


    public static void Main(string[] args)
    {
        int x = 123;
        long MinTime = long.MaxValue;
        long MaxTime = long.MinValue;
        long Sum=0;
        Thread[] thread = new Thread[10];

        for (int i = 0;i < 10;i++)
        {
            thread[i] = new Thread(() =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                int count = ListGenerate(123);
                sw.Stop();
                MaxTime = Math.Max(sw.ElapsedMilliseconds, MaxTime);
                MinTime = Math.Min(sw.ElapsedMilliseconds, MinTime);
                Sum += sw.ElapsedMilliseconds;
                //Console.WriteLine("Найдено {0} таких элементов", сount);


            });
            thread[i].Start();
        }

        for (int i = 0; i < 10;i++)
        {
            thread[i].Join();
        }

        double SrTime = Sum / 10;

        Console.WriteLine("min = {0}, max = {1}, sredneye={2}", MinTime, MaxTime, SrTime);

    }

}