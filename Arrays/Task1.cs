namespace Arrays;

public class Task1
{
    public static void Main()
    {
        Random rnd = new Random();
        int c, n, k = 1;
        c = rnd.Next(1, 11);
        Console.WriteLine("Ввидите число");
        n = Convert.ToInt32(Console.ReadLine());
        while (n != c)
        {
            if (n < c)
                Console.WriteLine("Ваше число меньше чем загаданное");
            else
                Console.WriteLine("Ваше число больше чем загаданное");
            Console.WriteLine("Ввидите еще раз число");
            n = Convert.ToInt32(Console.ReadLine());
            k = k + 1;
        }
        Console.WriteLine("ПОБЕДА!");
        Console.WriteLine($"Вы угадали число с {k} попытки, число было: {c}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}