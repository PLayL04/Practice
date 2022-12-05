namespace Inheritance
{
    public class ElectricianDepartment: Department
    {
        string Name = "Электрик";
        double MinScore = 4.5;
        public override void StaffSelection(List<Person> candidates)
        {
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].Score >= MinScore && candidates[i].PersonSpeciality == Speciality.Electrician)
                {
                    Employees.Add(candidates[i]);
                    candidates.Remove(candidates[i]);
                }
            }
        }
        public new string PrintEmployees()
        {
            string result = "==Список сотрудников департамента " + Title + "==\n";
            foreach (var item in Employees)
            {
                result += item.Name + " " + item.Score + "\n";
            }
            result += "--------------";
            return result;
        }
    }
}
