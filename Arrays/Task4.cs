namespace Arrays;

public class Task4
{
    public static void Main()
    {
        static void Main(string[] args)
        {
            double[] abc = new double[10];
            int A, B, C, D;
            double y, sum = 0, cp = 0;
            Console.WriteLine();
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < 10; x++)
            {
                y = A * Math.Sqrt(B * x + D) - C * x;
                abc[x] = y;
            }

            foreach (double x in abc)
            {
                if (x > 0)
                {
                    sum += x;
                }
                cp = x;
            }

            Console.WriteLine(sum);
            Console.WriteLine(cp / 10);
        }
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }
}