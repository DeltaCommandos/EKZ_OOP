
public class Yomayo
{
    private void Introvert(string Text)
    {
        Console.WriteLine(Text);
    }
    public void Extravert(string Text)
    {
        Introvert(Text);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Yomayo Yo = new Yomayo();
        Yo.Extravert("Privet");
    }
}