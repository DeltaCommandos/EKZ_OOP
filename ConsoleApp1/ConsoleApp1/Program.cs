
public class Z1
{
    public Z1(int a, string b)
    {
        Number = a; Text = b;
    }
    public int Number {  get; }
    public string Text { get;}


  
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Massive length");

        int N = int.Parse(Console.ReadLine());
        Z1[] z1 = new Z1[N];
        Random rnd = new Random();
        for (int i = 0; i < N; i++)
        {
            int x = rnd.Next();
            string y = Guid.NewGuid().ToString();
            z1[i] = new Z1(x, y);

        }

        Console.WriteLine("Massive elements");
        foreach (Z1 elem in z1)
        {
            Console.WriteLine($"Number: {elem.Number}, Text: {elem.Text}");
        }
    }
}