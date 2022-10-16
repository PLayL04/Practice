namespace Сonditions_and_Сycles;

public class Task1
{
    public static void Main()
    {
        int n;
        Console.Write("Каким стоит Сережа при расчете n: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cережа скажет, что он ");
        if (n % 2 == 0)
            Console.WriteLine("Второй");
        else
            Console.WriteLine("Первый");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}