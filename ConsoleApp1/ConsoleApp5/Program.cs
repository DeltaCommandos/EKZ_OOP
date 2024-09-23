

abstract public class Bowl
{
    public virtual void Pelmen()
    {
        Console.WriteLine("Pelmen in bowl");
    }

    public abstract void Varenik();
}

public class Spoon: Bowl
{
    public override void Pelmen()
    {
        Console.WriteLine("Pelmen in spoon");
    }

    public override void Varenik()
    {
        Console.WriteLine("Varenik in spoon");
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        Spoon spoon = new Spoon();
        spoon.Pelmen();
        spoon.Varenik();
    }
}