
public interface IFruit
{
    void Banana();
    void Apple();
    void Apricot();

}


public class Kompot: IFruit
{
    public void Banana()
    {
        Console.WriteLine("Banana");
    }

    public void Apple()
    {
        Console.WriteLine("Apple");
    }
    public void Apricot()
    {
        Console.WriteLine("Apricot");
    }

}


public class Program
{
    public static void Main(string[] args)
    {
        IFruit fruit = new Kompot();
        fruit.Banana();
        fruit.Apple();
        fruit.Apricot();
    }
}