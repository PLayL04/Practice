namespace Arrays;

public class Task5
{
    public static void Main()
    {
        Random rnd = new Random();
        int N, max_ = 0;
        Console.WriteLine("сколько чисел в массиве:");
        N = Convert.ToInt32(Console.ReadLine());
        double[] N_ = new double[N + 1];
        for (int x = 0; x < N; x++)
        {
            N_[x] = rnd.Next(1, 50);
        }

        Console.WriteLine("получившийся массив:");
        foreach (var d in N_)
        {
            var i = (int)d;
            max_ = Math.Max(max_, i);
            N_[N] = max_;
        }

        foreach (var d in N_)
        {
            var i = (int)d;
            Console.WriteLine(i);
        }
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}