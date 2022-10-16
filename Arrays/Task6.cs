namespace Arrays;

public class Task6
{
    public static void Main()
    {
        int count = 0;
        double radius = Convert.ToInt32(Console.ReadLine());
        double[,] coord = new double[12, 12];
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                coord[i, j] = random.Next(-10, 10);
            }
        }
        for (int i = 0; i < 12; i++)
        {
            double dlina = Math.Sqrt(Math.Pow(coord[i, 0], 2) + Math.Pow(coord[i, 1], 2));
            if (dlina > 2 * radius)
            {
                count += 1;
            }
        }
        Console.WriteLine(12 - count);
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}