namespace Intro;

public class Task3
{
    public static void Main()
    {
        double lenght = 163, speed, time, mark;
        int lap;
        Console.Write("С какой скоростью ехал автомобиль (в км/ч)? ");
        speed = Convert.ToDouble(Console.ReadLine());
        Console.Write("Сколько времени он ехал (в ч)? ");
        time = Convert.ToDouble(Console.ReadLine());
        lap = Convert.ToInt32(speed * time / lenght);
        mark = speed * time - lenght * lap;
        Console.WriteLine($"Автомобиль остановился на отметке {mark} км\n" +
                          $"Автомобиль проехал {lap} круг(ов)");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}