namespace Сonditions_and_Сycles;

public class Task5
{
    public static void Main()
    {
        int s;
        Console.Write("Введите скорость автомобиля s: ");
        s = Convert.ToInt32(Console.ReadLine());
        if (s - 90 < 20)
            Console.WriteLine("Скорость автомобиля допустима на данном участке");
        else if (s - 90 < 40 & s - 90 >= 20)
            Console.WriteLine("Водитель получит штраф в размере 500 рублей");
        else if (s - 90 < 60 & s - 90 >= 40)
            Console.WriteLine("Водитель получит штраф в размере 1500 рублей");
        else if (s - 90 < 80 & s - 90 >= 60)
            Console.WriteLine("Водитель получит штраф в размере 2500 рублей или лишение прав на 4 месяца");
        else if (s - 90 >= 80)
            Console.WriteLine("Водитель получит штраф в размере 5000 рублей или лишение прав на пол года");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}