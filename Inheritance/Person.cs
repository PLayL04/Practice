namespace Inheritance
{
    public class Person
    {
        private string name = "indefinite";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        private int age = 0;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
        private double score = 0.0;
        public double Score
        {
            get
            {
                return score;
            }
            set
            {
                this.score = value;
            }
        }
        public Speciality personSpeciality;
        public Speciality PersonSpeciality
        {
            get
            {
                return personSpeciality;
            }
            set
            {
                this.personSpeciality = value;
            }
        }
        public Person(string _name, int _age, double _score, Speciality _personSpeciality)
        {
            name = _name;
            age = _age;
            score = _score;
            personSpeciality = _personSpeciality;
        }
    }
}
