namespace Interface
{
    /* 
     *  Интерфейс представляет ссылочный тип, который может определять некоторый 
     *  функционал - набор методов и свойств без реализации. Затем этот функционал 
     *  реализуют классы и структуры, которые применяют данные интерфейсы.
     */
    interface IHaveAngryTeacher
    {
        bool AutomaticCredit { get; set; }
    }
    interface IHavePractice
    {
        int PracticeCount { get; set; }
    }
    interface IHaveFinalControll
    {
        int FinalControlCount { get; set; }
    }
}
