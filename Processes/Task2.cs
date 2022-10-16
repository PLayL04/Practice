namespace Processes;

public class Task2
{
    public static void Main()
    {
        var people = new Dictionary<string, int>()
        {
            {"Маша", 10000},
            {"Петя", 30000},
            {"Вася", 100000}
        };
        Console.Write("Введите имя и сумму: ");
        string[] input = Console.ReadLine().Split();
        string name = input[0];
        int money = Convert.ToInt32(input[1]);
        if (people.ContainsKey(name))
        {
            people[name] += money;
            Console.WriteLine($"{name}, Ваш баланс счета изменен! Текущий баланс {people[name]} рублей.");
        }
        else
        {
            people.Add(name, money);
            Console.WriteLine($"Благодарим, что вы стали клиентом нашего банка! {name}, " +
                              $"Ваш баланс счета изменен! Текущий баланс {people[name]} рублей");
        }
        Win(people[name]);
        Console.Write("Нажмите, чтобы завершить...");
        Console.ReadKey();
    }

    static void Win(int balance)
    {
        Console.WriteLine("Вы можете воспользоваться стандартным вкладом нашего банка! \n" +
                          $"Вложив сумму остатка {balance} на 3 года под 17% годовых Вы получите прибыль {(balance*Math.Pow(1.17, 3) - balance)}.\n" +
                          " Для активации вклада войдите в мобильное приложение!");
    }
}
