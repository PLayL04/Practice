namespace Interface
{
    class Programming : Discipline
    {
        public Programming(string name = "Программирование") : base(name) { AutomaticCredit = true; PracticeCount = 9; FinalControlCount = 0; }
    }
    class History : Discipline
    {
        public History(string name = "История") : base(name) { AutomaticCredit = true; PracticeCount = 10; FinalControlCount = 80; }
    }
    class MathematicalAnalysis : Discipline
    {
        public MathematicalAnalysis(string name = "Математический анализ") : base(name) { AutomaticCredit = false; PracticeCount = 10; FinalControlCount = 80; }
    }
}
