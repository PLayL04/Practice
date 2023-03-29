namespace U_Harchi.Foods.SemiFinishedFoods
{
    internal class DumplingsMeat : ISemiFinishedFood
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public DumplingsMeat()
        {
            Proteins = true;
            Fats = false;
            Carbohydrates = false;
        }
    }
}
