namespace Сonditions_and_Сycles;

public class Task2
{
    public static void Main()
    {
        int a, b, c;
        Console.Write("Введите первую сторону треугольника a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите вторую сторону треугольника b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третью сторону треугольника c: ");
        c = Convert.ToInt32(Console.ReadLine());
        double n = (180 / Math.PI) * Math.Acos((double)(a * a - b * b - c * c) / (2 * b * c));
        if (a * a == b * b + c * c | b * b == a * a + c * c | c * c == b * b + a * a)
            Console.WriteLine("Является прямоугольным треугольником");
        else
            Console.WriteLine("Не является прямоугольным треугольником. Угол c = {0}", n);
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}