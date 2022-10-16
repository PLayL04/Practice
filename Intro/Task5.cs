namespace Intro;

public class Task5
{
    public static void Main()
    {
        double a, b, c, d;
        Console.Write("Введите a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c: ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите d: ");
        d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Z = {a / c * (b / d) - (a * b - c) / (c * d) + Math.Sqrt(d)}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}