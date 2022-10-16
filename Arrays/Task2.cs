namespace Arrays;

public class Task2
{
    public static void Main()
    {
        int n, sumNum = 0, i;
        double sumSqr = 0;
        Console.Write("Ввидеть число: ");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= n; i++)
        {
            if (sumSqr < 500)
            {
                sumNum += i;
                sumSqr += i * i;
            }
            else
                break;
        }
        Console.WriteLine($"Сумма чисел: {sumNum}, сумма квадратов: {sumSqr}");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}