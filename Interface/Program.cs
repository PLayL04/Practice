using Interface;

internal class Program
{
    static void Main(string[] args)
    {
        List<Discipline> Discipline = new List<Discipline>()
            {
                new Programming(),
                new History(),
                new MathematicalAnalysis()
            };
        List<Student> Students = new List<Student>()
            {
                new Student("Геннадий")
                {
                    Practical =
                    {
                        {"Программирование", 10},
                        {"История", 18},
                        {"Математический анализ", 1}
                    },
                    Control =
                    {
                        {"Программирование", 0},
                        {"История", 90},
                        {"Математический анализ", 0}
                    }
                },
                new Student("Алексей")
                {
                    Practical =
                    {
                        {"Программирование", 9},
                        {"История", 10},
                        {"Математический анализ", 10}
                    },
                    Control =
                    {
                        {"Программирование", 0},
                        {"История", 80},
                        {"Математический анализ", 80}
                    }
                },
                new Student("Вася")
                {
                    Practical =
                    {
                        {"Программирование", 10},
                        {"История", 11},
                        {"Математический анализ", 11}
                    },
                    Control =
                    {
                        {"Программирование", 1},
                        {"История", 81},
                        {"Математический анализ", 81}
                    }
                },
                new Student("Гоша")
                {
                    Practical =
                    {
                        {"Программирование", 8},
                        {"История", 9},
                        {"Математический анализ", 9}
                    },
                    Control =
                    {
                        {"Программирование", 0},
                        {"История", 79},
                        {"Математический анализ", 79}
                    }
                },
            };
        foreach (Student student in Students)
        {
            Console.WriteLine($"Данные по зачетам у обучающегося {student.Name}:");
            string output = "";
            foreach (Discipline disciplines in Discipline)
            {
                output += disciplines.Check(student);
            }
            Console.WriteLine($"{output}");
        }

    }
}