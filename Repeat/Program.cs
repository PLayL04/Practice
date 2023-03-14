/*
 *  Вариант 3
 */
namespace Repeat;
internal class Repeat
{
    public static void Pause()
    {
        Console.Write("Нажмите чтобы продолжить...");
        Console.ReadKey();
    }
    private static void Main(string[] args)
    {
        //Task1.Start();
        //Task2.Start();
        Task3.Start();
    }
}