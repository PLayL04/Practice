namespace U_Harchi.Foods.Snacks
{
    internal class ChocolateBar : ISnack
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public ChocolateBar()
        { 
            Proteins = false;
            Fats = false;
            Carbohydrates = true;
        }
    }
}
