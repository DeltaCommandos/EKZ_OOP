using System;


public class Yomayo
{
    public void Printer(int a)
    {
        Console.WriteLine(a);
    }

    public void Printer2(int a)
    {
        Console.WriteLine(a+a);
    }


    public delegate void DPrintter(int a);
    private DPrintter dp;

    public void CallPrinter(int a)
    {
        dp(a);
    }

    public event DPrintter PrinterEvent
    {
        add
        {
            dp += value;
            Console.WriteLine("Прикатились");
        }
        remove
        {
            dp -= value;
            Console.WriteLine("Укатились");
        }
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        Yomayo Yo=new Yomayo();
        Yo.PrinterEvent += Yo.Printer;
        Yo.CallPrinter(1311);
        Yo.PrinterEvent += Yo.Printer;
        Yo.CallPrinter(42);

        Yo.PrinterEvent -= Yo.Printer;
        Yo.CallPrinter(13);


    }
}