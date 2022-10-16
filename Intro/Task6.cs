namespace Intro;

public class Task6
{
    public static void Main()
    {
        double a, b, c, p;
        Console.Write("Введите сторону a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону c: ");
        c = Convert.ToDouble(Console.ReadLine());
        p = (a + b + c) / 2;
        Console.WriteLine($"Площадь равна {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}