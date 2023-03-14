namespace Repeat
{
    public class Task2
    {
        public static void Start()
        {
            int a, b, c, d;
            Console.Write("Введите числа a, b, c, d (каждый через новую строку):\n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            List<float> list = new List<float>();
            for (int x = 1; x <= 10; x++)
            {
                float y = (float)(a * (Math.Sqrt(b * x + d) - c * x));
                list.Add(y);
            }
            Console.Write("Положительные значения:");
            foreach (float x in list)
            {
                if (x > 0)
                    Console.Write($" {x}");
            }
            Console.WriteLine($"\nСреднее значение y: {list.Average()}");
        } 
    }
}
