namespace Processes;

public class Task3
{
    public static void Main()
    {
        Console.Write("Введите предложение: ");
        string[] sentence = Console.ReadLine().Split();
        string max = "";
        foreach (var item in sentence)
        {
            if (item.Length > max.Length)
                max = item;
        }
        Console.WriteLine($"Самое длинное: {max}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}