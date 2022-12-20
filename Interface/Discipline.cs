namespace Interface
{
    abstract class Discipline : IHaveAngryTeacher, IHavePractice, IHaveFinalControll
    {
        string Name;
        public bool AutomaticCredit { get; set; }
        public int PracticeCount { get; set; }
        public int FinalControlCount { get; set; }
        public Discipline(string name)
        {
            Name = name;
        }

        public string Check(Student student)
        {
            bool PracticeCheck = true;
            bool FinalControlCheck = true;
            if (AutomaticCredit)
            {
                if (!(student.Practical[Name] >= PracticeCount))
                {
                    PracticeCheck = false;
                }
                if (!(student.Control[Name] >= FinalControlCount))
                {
                    FinalControlCheck = false;
                }
                if (PracticeCheck && FinalControlCheck)
                {
                    return $"\tЕсть автомат по {Name}!\n";
                }
                else
                {
                    return $"\tПока нет автомата по {Name}.\n";
                }
            }
            else
            {
                return $"\tНельзя получить автомат по {Name}!\n";
            }
        }
    }
}
