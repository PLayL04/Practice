namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Система система <Потрать стипендию разумно>");
            StudentOfISIT student = null;           
            Console.WriteLine("Функции:\n" +
                "1. Задать имя\n" +
                "2. Ввести информацию\n" +
                "3. Получить деньги\n" +
                "4. Потратить деньги\n" +
                "5. Баланс\n" +
                "6. Выход");
            bool isCycle = true;
            while (isCycle)
            {
                Console.Write("Введите номер функции: ");
                int? arg = Convert.ToInt32(Console.ReadLine());
                switch (arg)
                {
                    case 1:
                        {
                            if (student == null)
                            {
                                Console.Write("Введите имя: ");
                                string? name = Console.ReadLine();
                                Console.Write("Введите специальность: ");
                                string? spec = Console.ReadLine();
                                student = new StudentOfISIT { Name = name, Speciality = spec };
                            }
                            else
                            {
                                Console.WriteLine("Имя и специальность уже заданны!");
                            }
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Console.WriteLine("Данные о студенте:\n" +
                                $"Имя: {student.Name}\n" +
                                $"Специальность: {student.Speciality}\n" +
                                $"Размер ежемесячной стипендии: {student.ScholarshipAmount}\n" +
                                $"Виртуальный счет: {student.Check}");
                            }
                            catch
                            {
                                Console.WriteLine("Студент не задан!");
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                student.GetAScholarship();
                                Console.WriteLine($"Текущий баланс {student.Check}");
                            }
                            catch
                            {
                                Console.WriteLine("Студент не задан!");
                            }
                            break;
                        }
                    case 4:
                        {
                            int money;
                            string itemOfExpenditure;
                            try
                            {
                                Console.Write("Введите сумму: ");
                                money = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите на что потрачено: ");
                                itemOfExpenditure = Console.ReadLine();
                                if (student.SpendAScholarship(money, itemOfExpenditure))
                                {
                                    Console.WriteLine($"Со счета списано {money} на {itemOfExpenditure}.");
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточно денег!");
                                }
                                Console.WriteLine($"Текущий баланс: {student.Check}");
                            }
                            catch
                            {
                                Console.WriteLine("Студент не задан!");
                            }
                            break;
                        }
                    case 5:
                        {
                            try
                            {
                                Console.WriteLine($"Текущий баланс: {student.Check}");
                            }
                            catch
                            {
                                Console.WriteLine("Студент не задан!");
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Выход...");
                            isCycle = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неверная команда!");
                            break;
                        }
                }
            }
        }
    }
}