namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentOfISIT student =  new StudentOfISIT();
            Console.WriteLine("Система система <Потрать стипендию разумно>\n" +
                "Функции:\n" +
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
                            if(student.Name == null && student.Speciality == null)
                            {
                                Console.Write("Введите имя студента: ");
                                student.Name = Console.ReadLine();
                                Console.Write("Введите специальность студента: ");
                                student.Speciality = Console.ReadLine();
                                Console.WriteLine($"Задано имя {student.Name}, задана специальность {student.Speciality}");
                            }
                            else
                            {
                                Console.WriteLine("Данные нельзя изменить!");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Данные о студенте:\n" +
                                $"Имя: {student.Name}\n" +
                                $"Специальность: {student.Speciality}\n" +
                                $"Размер ежемесячной стипендии: {student.ScholarshipAmount}\n" +
                                $"Виртуальный счет: {student.Check}");
                            break;
                        }
                    case 3:
                        {
                            student.GetAScholarship();
                            Console.WriteLine($"Текущий баланс {student.Check}");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Введите сумму: ");
                            int money = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите на что потрачено: ");
                            string? itemOfExpenditure = Console.ReadLine();
                            if (student.SpendAScholarship(money, itemOfExpenditure))
                            {
                                Console.WriteLine($"Со счета списано {money} на {itemOfExpenditure}.");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно денег!");
                            }
                            Console.WriteLine($"Текущий баланс: {student.Check}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Текущий баланс: {student.Check}");
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