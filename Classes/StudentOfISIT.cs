namespace Classes
{
    public class StudentOfISIT
    {
        public string? Name { set; get; }
        public string? Speciality { set;  get; }
        public int ScholarshipAmount { set; get; } = 2916;
        public int Check { set; get; } = 2916;
        public bool Warning 
        { 
            get
            {
                if (this.Check > 100)
                    return false;
                else
                    return true;
            }
        }
        public StudentOfISIT() { }
        public void GetAScholarship()
        {
            if (DateTime.Now.Day == 20)
            {
                this.Check += ScholarshipAmount;
            }
        }
        public bool SpendAScholarship(int money, string itemOfExpenditure)
        {
            if (this.Warning == false && this.Check - money >= 0)
            {
                this.Check -= money;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
