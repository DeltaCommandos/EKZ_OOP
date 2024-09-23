using System;
using System.Diagnostics;


public class Program
{
   public static void RunLoop()
   {
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("key is pressed");
            }
        }

    }
    public static void Main(string[] args)
    {
        Thread thread = new Thread(RunLoop);
        thread.Start();

    }



}