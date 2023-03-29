namespace U_Harchi.Foods.Snacks
{
    internal class BalykCheese : ISnack
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public BalykCheese()
        {
            Proteins = true;
            Fats = false;
            Carbohydrates = false;
        }
    }
}
