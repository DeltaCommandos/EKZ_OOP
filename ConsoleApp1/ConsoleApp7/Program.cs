using System;


public class Yomayo<T>
{
    public void TypeTyper()
    {
        Console.WriteLine(typeof(T).Name);
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        Yomayo<int> I = new Yomayo<int>();
        Yomayo<char> C = new Yomayo<char>();

        I.TypeTyper();
        C.TypeTyper();
    }
}