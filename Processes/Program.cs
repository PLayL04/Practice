using Processes;

Console.Write("Какую программу запустить?: ");
int arg = Convert.ToInt32(Console.ReadLine());
switch (arg)
{
    case 1:
        {
            Task1.Main();
            break;
        }
    case 2:
        {
            Task2.Main();
            break;
        }
    case 3:
        {
            Task3.Main();
            break;
        }
    default:
        {
            Console.WriteLine("Нет такой программы!");
            Console.Write("Нажмите, чтобы завершить...");
            Console.ReadKey();
            break;
        }
}