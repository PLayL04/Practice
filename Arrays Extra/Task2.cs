namespace Arrays_Extra;

public class Task2
{
    public static void Main()
    {
        Random random = new Random();
        int[] mass = new int[random.Next(1, 10)]; // создаем массив
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = random.Next(-10, 10); // заполняем его значениями
        }
        int first = 0, last = mass.Length - 1, sum = 0;
        for (int i = 0; i < mass.Length; i++) // ищем первый нуль
        {
            if (mass[i] == 0)
            {
                first = i;
                break;
            }
        }
        for (int i = (mass.Length - 1); i > -1; i--) // ищем последний нуль
        {
            if (mass[i] == 0)
            {
                last = i;
                break;
            }
        }
        for (int i = first; i < last; i++) // суммируем значения от первого до последнего
        {
            sum += mass[i];
        }
        Console.WriteLine($"Сумма равна: {sum}");
    }
}