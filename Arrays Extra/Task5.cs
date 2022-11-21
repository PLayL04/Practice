namespace Arrays_Extra
{
    public class Task5
    {
        public static void Main()
        {
            int[,] mass = new int[,] { { 0, 1, 1 }, { 3, 4, 5 }, { 0, 7, 8 }, { 4, 4, 4 } };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    bool flag = dict.ContainsKey(mass[i, j]);
                    if (dict.ContainsKey(mass[i, j]))
                    {
                        int value = mass[i, j] + 1;
                        dict.Remove(mass[i, j]);
                        dict.Add(mass[i, j], value);
                    }
                    else
                    {
                        dict.Add(mass[i, j], 1);
                    }
                }
                int[] max = new int[2] { 0, 0 };
                foreach(var n in dict)
                {
                    if (max[1] < n.Value)
                    {
                        max[0] = n.Key;
                        max[1] = n.Value;
                    }
                }
                dict.Clear();
                dict2.Add(i, max[1]);
            }
            int[] maxx = new int[2] {0,0};
            foreach (var n in dict2)
            {
                if (maxx[1] < n.Value)
                {
                    maxx[1] = n.Value;
                    maxx[0] = n.Key;
                }
            }
            Console.WriteLine(maxx[0]);
        }
    }
}
