
public class Yomayo
{
    public Yomayo(int a, bool b)
    {
        Number = a; Switch = b;
    }
    public int Number { get; }
    public bool Switch { get; }


}

public class Blin: Yomayo
{
    public Blin(int a, bool b):base(a, b) {
    
    }
    
}



public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Massive length");

        int N = int.Parse(Console.ReadLine());
        Yomayo[]Yo1 = new Yomayo[N];
        Yomayo[] Yo2 = new Yomayo[N];

        Random rnd = new Random();
        for (int i = 0; i < N; i++)
        {
            int x = rnd.Next();
            bool y = rnd.Next(2)==0;
            Yo1[i] = new Yomayo(x, y);


            x = rnd.Next();
            y = rnd.Next(2) == 0;
            Yo2[i] = new Yomayo(x, y);
        }
        int c1=0, c2=0;
        for (int i = 0;i < N; i++)
        {
            if (Yo1[i].Switch==false)
            {
                c1++;
            }
            if (Yo2[i].Switch == false)
            {
                c2++;
            }
            Console.WriteLine("1 массив: {0} {1}. 2 массив: {2} {3}", Yo1[i].Number, Yo1[i].Switch, Yo2[i].Number, Yo2[i].Switch);
        }



        Console.WriteLine(c1>c2?"В первом больше":"Во втором больше");
        
    }
}