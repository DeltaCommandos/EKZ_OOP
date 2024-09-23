using System;
using System.Runtime.InteropServices;


public class Yomayo
{
    public int Number {  get; set; } = 54;
    public string Name { get; set; } = "Gawooga";

    public Yomayo(int n, string s)
    {
        Number = n;
        Name = s;
    }
}

public class Gear2<T> where T: Yomayo
{
    
    public void printer(T item)
    {
        Console.WriteLine("{0} {1}",item.Number,item.Name);
    }
}



public class Program
{
    public static void Main(string[] args)
    {

        Yomayo Yo = new Yomayo(42, "Yo");
        Gear2<Yomayo> Gear=new Gear2<Yomayo>();

        Gear.printer(Yo);
    }
}