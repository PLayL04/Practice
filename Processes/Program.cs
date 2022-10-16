Console.Write("Какую программу запустить?: ");
int arg = Convert.ToInt32(Console.ReadLine());
switch (arg)
{
    default:
    {
        Console.WriteLine("Нет такой программы!");
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
        break;
    }
}