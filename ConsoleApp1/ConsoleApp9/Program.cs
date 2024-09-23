using System;
using System.Runtime.InteropServices;




public class Yomayo
{
    public void Printer(int a, string s, bool b)
    {
        Console.WriteLine("{0} {1} {2}",a,s,b);
    }

    public int Counter(int[] a, double b)
    {
        a[0] = (int)b;
        return a[0];
    }
}



public class Program
{
    public delegate void VoidDeleg(int a, string s, bool b);
    public delegate int IntDeleg(int[] a, double b);

    public static void Main(string[] args)
    {
        Yomayo Yo = new Yomayo();

        VoidDeleg DV = Yo.Printer;
        IntDeleg DC = Yo.Counter;

        int[]a = new int[3];


        DV(1, "qq", true);
        a[0] = DC(a,12.7845);
        Console.WriteLine(a[0]);
    }
}