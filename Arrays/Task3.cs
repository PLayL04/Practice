namespace Arrays;

public class Task3
{
    public static void Main()
    {
        bool isManual = false;
        Random random = new Random();
        Console.Write("На зачет пришло: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] pod = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (isManual)
            {
                Console.Write($"{i} подтянулся: ");
                pod[i] = Convert.ToInt32(Console.ReadLine());
            }
            else
                pod[i] = random.Next(1, 25);
        }
        int three = 0, four = 0, five = 0;
        foreach (int i in pod)
        {
            if (i < 14 && i >= 12)
                three++;
            if (i < 16 && i >= 14)
                four++;
            if (i >= 16)
                five++;
        }
        Console.WriteLine($"На 3 сдало {three} человек(а), на 4 сдало {four} человек(а), на 5 сдало {five} человек(а)");
        Console.WriteLine($"Максимально {pod.Max()}, минимально {pod.Min()}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}