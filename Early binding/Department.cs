namespace Inheritance
{
    public class Department
    {
        public string Title { get; init; } = "und";
        public List<Person> Employees { get; set; } = new List<Person>();
        double MinScore = 3.0;
        public virtual void StaffSelection(List<Person> candidates)
        {
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].Score >= MinScore)
                {
                    Employees.Add(candidates[i]);
                    candidates.Remove(candidates[i]);
                }
            }
        }
        public string PrintEmployees()
        {
            string result = "==Список сотрудников департамента " + Title + "==\n";
            foreach (var item in Employees)
            {
                result += item.Name + "\n";
            }
            result += "--------------";
            return result;
        }

    }
}
