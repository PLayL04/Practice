namespace Arrays_Extra
{
    public class Task5
    {
        public static void Main()
        {
            int[,] mass = new int[,] { { 0, 1, 1 }, { 3, 4, 5 }, { 0, 7, 8 }, { 1, 1, 1 } };
            List<int> list = new List<int>();
            bool flag = false;
            int l = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                if (flag)
                {
                    list.Add(l);
                }
                if (!flag)
                {
                    list.Add(0);
                }
                l = 0;
                flag = false;
                for (int j = 1; j < mass.GetLength(1); j++)
                {
                    if (mass[i,j] == mass[i, j - 1] && !flag)
                    {
                        flag = true;
                        l += 1;
                    }
                    else if (mass[i, j] != mass[i, j - 1] && flag)
                    {
                        list.Add(l);
                        l = 0;
                        flag = false;
                    }
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
