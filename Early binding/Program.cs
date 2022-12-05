namespace Inheritance
{
    public enum Speciality
    {
        Electrician,
        Mechanic,
        Mathematician,
        Programmer,
        Lawyer
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            Person person1 = new Person("Витя", 19, 4.5, Speciality.Electrician);
            Person person2 = new Person("Вова", 29, 4.1, Speciality.Mechanic);
            Person person3 = new Person("Саша", 23, 4, Speciality.Mathematician);
            Person person4 = new Person("Кеша", 23, 5.0, Speciality.Programmer);
            Person person5 = new Person("Митя", 54, 5, Speciality.Lawyer);
            Person person6 = new Person("Леня", 11, 2.9, Speciality.Mathematician);
            Person person7 = new Person("Степа", 35, 1.9, Speciality.Electrician);

            factory.Candidates.Add(person1);
            factory.Candidates.Add(person2);
            factory.Candidates.Add(person3);
            factory.Candidates.Add(person4);
            factory.Candidates.Add(person5);
            factory.Candidates.Add(person6);
            factory.Candidates.Add(person7);

            factory.Departments = new List<Department>()
            {
                new ElectricianDepartment() {
                    Title = "Electrician Department"
                },
                new MechanicDepartment() {
                    Title = "Mechanic Department"
                },
                new InformDepartment() {
                    Title = "Inform Department"
                }
            };
            foreach (Department department in factory.Departments)
            {
                department.StaffSelection(factory.Candidates);
                Console.WriteLine($"Специалисты из {department.Title}:");
                foreach (Person specialist in department.Employees)
                {
                    Console.WriteLine($"\tИмя = {specialist.Name}.");
                    Console.WriteLine($"\tВозраст = {specialist.Age}.");
                    Console.WriteLine($"\tСпециальность = {specialist.PersonSpeciality.ToString()}.");
                    Console.WriteLine($"\tСредний балл = {specialist.Score}.\n");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine($"Специалисты, которые не прошли:");
            foreach (Person candidate in factory.Candidates)
            {
                Console.WriteLine($"\tИмя = {candidate.Name}.");
                Console.WriteLine($"\tВозраст = {candidate.Age}.");
                Console.WriteLine($"\tСпециальность = {candidate.PersonSpeciality.ToString()}.");
                Console.WriteLine($"\tСредний балл = {candidate.Score}.\n");
            }
            foreach(Department department in factory.Departments)
            {
                Console.WriteLine(department.PrintEmployees());
            }
        }
    }
}