using System.Text.RegularExpressions;

namespace Processes;

public class Task4
{
    public static void Main()
    {
        Console.Write("Введите пароль: ");
        string pass = Console.ReadLine();
        Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])\S{1,12}$");
        Console.WriteLine(regex.IsMatch(pass));
    }
}