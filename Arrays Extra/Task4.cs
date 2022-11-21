namespace Arrays_Extra
{
    public class Task4
    {
        public static void Main()
        {
            int[,] mass = new int[,] { { 0, 1, 2 }, { 3, 0, 5 }, { 0, 7, 8 }, { 1, 1, 1 } }; 
            int[] count = new int[mass.GetLength(1)]; // наличие в стобцах нулей
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] == 0)
                    {
                        count[j] = 1;
                    }
                }
            }
            int sum = 0;
            foreach (int i in count)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
