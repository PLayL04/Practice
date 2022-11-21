namespace Arrays_Extra
{
    public class Task1
    {
        static public void Main(int[] input)
        {
            int[] mass = input;
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