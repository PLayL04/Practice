namespace Classes
{
    public class StudentOfISIT
    {
        string Name { init; get; }
        string Speciality { set;  get; }
        int ScholarshipAmount { set; get; }
        int Check { set; get; }
        bool Warning { get; }
        public StudentOfISIT() { }
        public void GetAScholarship()
        {
            if (DateTime.Now.Day == 20)
                this.Check += ScholarshipAmount;
        }
        public void SpendAScholarship(int money, string itemOfExpenditure)
        {
            if (Warning)
            {
                this.Check -= money;
                Console.WriteLine(itemOfExpenditure, money);
            }
            else
            {
                Console.WriteLine("Денег на счету нет!");
            }
        }
    }
}
