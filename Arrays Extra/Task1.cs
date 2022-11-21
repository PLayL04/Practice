namespace Arrays_Extra
{
    public class Task1
    {
        static public void Main()
        {
            Random random = new Random();
            int[] mass = new int[random.Next(1, 10)]; // создаем массив
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(-10, 10); // заполняем его значениями
            }
            int sum = 0;
            for (int i = 1; i < mass.Length; i += 2)
            {
                try
                {
                    sum += mass[i];
                }
                catch
                {
                    continue;
                }
            }
            Console.WriteLine($"Сумма равна: {sum}");
        }
    }
}