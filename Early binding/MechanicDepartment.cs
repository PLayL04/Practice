namespace Inheritance
{
    public class MechanicDepartment: Department
    {
        string Name = "Механик";
        double MinScore = 4.0;
        int MaxAge = 35;
        public override void StaffSelection(List<Person> candidates)
        {
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].Age <= MaxAge && candidates[i].Score >= MinScore && candidates[i].PersonSpeciality == Speciality.Mechanic)
                {
                    Employees.Add(candidates[i]);
                    candidates.Remove(candidates[i]);
                }
            }
        }
        public new string PrintEmployees()
        {
            return base.PrintEmployees() + "sdf";
        }
    }
}
