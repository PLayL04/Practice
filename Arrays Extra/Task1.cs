namespace Arrays_Extra;
// Дан массив, состоящий из n вещественных элементов, вычислить:
// 1.произведение элементов массива с четными номерами;
// TODO 2.сумму элементов массива, расположенных между первым и последним нулевыми элементами;
// TODO 3.преобразовать массив таким образом, чтобы сначала располагались все положительные элементы,
//   а потом - все отрицательные (элементы, равные 0, считать положительными).
public class Task1
{
    public static void Main()
    {
        int sumEvem = 0, sumZero = 0;
        bool flag = false;
        Random random = new Random();
        int[] array = new int[random.Next(1, 10)];
        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(-10, 10);
        foreach (var item in array)
        {
            if (item == 0)
                flag = true;
            if (item % 2 == 0) sumEvem += item;
            if (flag)
            {
                
            }
            
        }
    }
}