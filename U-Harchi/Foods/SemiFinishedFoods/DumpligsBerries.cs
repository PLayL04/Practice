namespace U_Harchi.Foods.SemiFinishedFoods
{
    internal class DumpligsBerries : ISemiFinishedFood
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public DumpligsBerries()
        {
            Proteins = true;
            Fats = false;
            Carbohydrates = false;
        }
    }
}
