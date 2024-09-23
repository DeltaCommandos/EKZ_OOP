using System;


public class Yomayo
{
    public int N1 { get; set; }
    public int N2 { get; set; }

    public Yomayo(int a, int b)
    {
        N1 = a;
        N2 = b;
    }

    public static Yomayo operator+(Yomayo Yo1, Yomayo Yo2)
    {
        return new Yomayo(Yo1.N1 + Yo2.N1, Yo1.N2 + Yo2.N2);
    }



}



public class Program
{
    public static void Main(string[] args)
    {
        Yomayo Yo1 = new Yomayo(1, 2);
        Yomayo Yo2 = new Yomayo(3,4);
        Yomayo S = Yo1 + Yo2;
        
        Console.WriteLine("{0} {1}", S.N1, S.N2);   
    }
}