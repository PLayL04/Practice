namespace Classes
{
    public class StudentOfISIT
    {
        public string Name { init; get; }
        public string Speciality { init;  get; }
        public int ScholarshipAmount { set; get; } = 2916;
        public int Check { set; get; } = 2916;
        private bool Flag // получил ли стипендию
        {
            get
            {
                if (this.DateFlag == DateTime.Now.Month)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private int DateFlag { set; get; } = 0;// дата получения стипендии
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
            if (DateTime.Now.Day == 7 && this.Flag == false)
            {
                this.Check += ScholarshipAmount;
                this.DateFlag = DateTime.Now.Month;
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
