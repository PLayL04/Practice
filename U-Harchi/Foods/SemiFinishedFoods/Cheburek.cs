namespace U_Harchi.Foods.SemiFinishedFoods
{
    internal class Cheburek : ISemiFinishedFood
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public Cheburek()
        {
            Proteins = true;
            Fats = false;
            Carbohydrates = false;
        }
    }
}
