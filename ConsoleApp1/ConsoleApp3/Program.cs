



public class Program
{

    public static int Med(int[] A)
    {
        int med = 0;
        int i = (int)(A.Length/2);

        if (A.Length % 2 != 0) {

            med = A[i];
        }
        else
        {
            med = A[i-1];

        }

        return med;
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("Пожалуйста, введите размер массива");

        int N;
        while (!int.TryParse(Console.ReadLine(), out N))
        {
            Console.WriteLine("Некорректный ввод");
        }

        int[] A = new int[N];
        Random rand = new Random(); 

        for (int i = 0; i < N; i++) {
            A[i] = rand.Next();
        }
        foreach(int i in A)
        {
            Console.WriteLine("Число: {0}",i);
        }
        Console.WriteLine("Медиана: {0}", Med(A));

    }
}