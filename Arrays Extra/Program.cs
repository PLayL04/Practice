using Arrays_Extra;
Random random = new Random();
int[] mass = new int[random.Next(1, 10)]; // создаем массив
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = random.Next(-10, 10); // заполняем его значениями
}
Task5.Main();