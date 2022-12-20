namespace Сonditions_and_Сycles;

public class Task4
{
    public static void Main()
    {
        static void Main(string[] args)
        {
            int m, s;
            Console.Write("Введите сумму вклада s: ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Возможные виды вкладов: \n" +
                              "1. Вклад на 1 год под 7% годовых\n" +
                              "2. Вклад на 3 года под 8% годовых.\n" +
                              "3. Вклад на 5 лет под 10% годовых.");
            Console.Write("Введите вид вклада m: ");
            m = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:
                    {
                        Console.WriteLine($"Ваша выручка: {s * 0.07}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Ваша выручка: {s * Math.Pow(1.08, 3) - s}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Ваша выручка: {s * Math.Pow(1.1, 5) - s}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Нет такого вклада");
                        break;
                    }
            }
            Console.Write("Нажмите, чтобы завершить...");
            Console.ReadKey();
        }
    }
}