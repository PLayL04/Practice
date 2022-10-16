namespace Processes;

public class Task1
{
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static int[] Collection(int[] coll)
    {
        int[] ans = new int[2];
        ans[0] = coll.Length;
        ans[1] = Sum(coll.Min(), coll.Max());
        return ans;
    }
    
    public static void Main()
    {
        Random random = new Random();
        int[] coll = new int[random.Next(5, 25)];
        for(int i = 0; i < 5; i++)
            coll[i] = random.Next(-10, 10);
        int[] a = Collection(coll);
        Console.WriteLine($"{a[0]} {a[1]}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}