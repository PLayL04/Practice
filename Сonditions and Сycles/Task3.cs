namespace Сonditions_and_Сycles;

public class Task3
{
    public static void Main()
    {
        Console.Write("Введите количество человек в очереди n: ");
        int n = int.Parse(Console.ReadLine());
        double d = (n / 2) * 20;
        if (n <= 50)
            Console.WriteLine($"Сергею стоит стоять в очереди. Время ожидания: {d}");
        else
            Console.WriteLine("Сергею не стоит стоять в очереди");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}