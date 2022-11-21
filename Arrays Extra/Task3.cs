namespace Arrays_Extra
{
    public class Task3
    {
        public static void Main(int[] input)
        {
            int[] mass = input;
            List<int> pos = new List<int> { mass.Length };
            List<int> neg = new List<int> { mass.Length };
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > -1)
                {
                    pos.Append(mass[i]);
                }
                else
                {
                    neg.Append(mass[i]);
                }
            }
            List<int> ans = new List<int>();
            ans.AddRange(pos);
            ans.AddRange(neg);
            foreach (int i in ans)
            {
                Console.Write(i);
            }
        }
    }
}
