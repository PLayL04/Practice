namespace Intro;

public class Task2
{
    public static void Main()
    {
        double x, y;
        Console.Write("Введите координату X точки: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату Y точки: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Угол равен {Math.Atan(y / x) * (180 / Math.PI)}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}