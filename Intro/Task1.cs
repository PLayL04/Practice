namespace Intro;

public class Task1
{
    public static void Main()
    {
        string? name, lang;
        Console.Write("Как Вас зовут? ");
        name = Console.ReadLine();
        Console.Write("Какой язык программирования Вы изучали ранее? ");
        lang = Console.ReadLine();
        Console.WriteLine($"Я {name}, я уже знаю {lang}!");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}