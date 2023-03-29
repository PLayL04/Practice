namespace U_Harchi.Foods.Snacks
{
    internal class Crisps : ISnack
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public Crisps()
        {
            Proteins = false;
            Fats = true;
            Carbohydrates = false;
        }
    }
}
