namespace Arrays_Extra
{
    public class Task3
    {
        public static void Main()
        {
            Random random = new Random();
            int[] mass = new int[random.Next(1, 10)]; // создаем массив
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(-10, 10); // заполняем его значениями
            }
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
