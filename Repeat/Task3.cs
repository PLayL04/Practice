using System.Diagnostics;

namespace Repeat
{
    public class Technician
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Technician(string name, int number) 
        {
            Name= name;
            Number = number;
        }
    }
    public class Defect
    {
        public int Number { get; init; }
        public string Name { get; set; }
        public string Equipment { get; set; }
        public string Description { get; set; }
        public Technician Technician { get; set; }
        public Defect(int number, string name, string equipment, string description, Technician technician)
        {
            Number = number;
            Name = name;
            Equipment = equipment;
            Description = description;
            Technician = technician;
        }
    }
    public class Task3
    {
        public static void Start()
        {
            List<Defect> defects = new List<Defect>();
            List<Technician> technicians= new List<Technician>();
            Console.Write("ИС 'Сервис'\n" +
                          "Выберите действие:\n" +
                          "1. Добавить техника\n" +
                          "2. Удалить техника\n" +
                          "3. Добавить задание\n" +
                          "4. Удалить задание\n" +
                          "5. Просмотр списков\n");
            
            while (true)
            {
                Console.Write("Введите номер: ");
                int v = Convert.ToInt32(Console.ReadLine());
                switch (v)
                {
                    case (1):
                        Console.Write("Введите имя и номер: ");
                        string[] input = Console.ReadLine().Split(' ');
                        Technician tec = new Technician(input[0], Convert.ToInt32(input[1]));
                        technicians.Add(tec);
                        break;
                    case (2):
                        Console.Write("Введите номер: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        foreach (Technician tec2 in technicians)
                        {
                            if (tec2.Number == n)
                            {
                                technicians.Remove(tec2);
                                Console.WriteLine("Удалено");
                            }
                        }
                        break;
                    case (3):
                        bool flag = false;
                        Console.Write("Введите номер, имя заказчика, предмет, описание и номер техника: ");
                        string[] input2 = Console.ReadLine().Split(' ');
                        Technician t = null;
                        foreach (Technician tec2 in technicians)
                        {
                            if (tec2.Number == Convert.ToInt32(input2[4]))
                            {
                                t = tec2;
                                flag = true;
                                break;
                            }
                        }
                        if (flag == true)
                        {
                            Defect def = new Defect(Convert.ToInt32(input2[0]), input2[1], input2[2], input2[3], t);
                            defects.Add(def);
                        }
                        break;
                        case (4):
                        {
                            Console.Write("введите номер: ");
                            int p = Convert.ToInt32(Console.ReadLine());
                            
                            foreach (Defect def in defects)
                            {
                                if (def.Number == p)
                                {
                                    defects.Remove(def);
                                    Console.WriteLine("Удалено");
                                }
                            }
                            break;
                        }
                    case (5):
                    {
                            Console.WriteLine("Техники");
                            foreach (var aa in technicians)
                            {
                                Console.WriteLine(aa.Name + " " + aa.Number);
                            }
                            Console.WriteLine("Задания");
                            foreach (var aa in defects)
                            {
                                Console.WriteLine(aa.Number + " " + aa.Name + " " + aa.Equipment + " " + aa.Description + " " + aa.Technician.Name + ' ' + aa.Technician.Number);
                            }
                            break;
                        }

                    default:
                        string[] a = Console.ReadLine().Split(' ');
                        foreach(string s in a) { Console.WriteLine(s); }
                        break;
                }
            }
            
        }
    }
}
