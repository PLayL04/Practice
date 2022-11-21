namespace Inheritance
{
    public class InformDepartment : Department
    {
        string Name = "Математик";
        double MinScore = 4.8;
        int MinAge = 22;
        public override void StaffSelection(List<Person> candidates)
        {
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].Age >= MinAge && candidates[i].Score >= MinScore && (candidates[i].PersonSpeciality == Speciality.Programmer || candidates[i].PersonSpeciality == Speciality.Mathematician))
                {
                    Employees.Add(candidates[i]);
                    candidates.Remove(candidates[i]);
                }
            }
        }
    }
}
