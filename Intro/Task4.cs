namespace Intro;

public class Task4
{
    public static void Main()
    {
        int upLimit, downLimit;
        Random random = new Random();
        Console.Write("Введите верхнюю границу: ");
        upLimit = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите нижнюю границию: ");
        downLimit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Случайное число: {random.Next(downLimit, upLimit)}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}