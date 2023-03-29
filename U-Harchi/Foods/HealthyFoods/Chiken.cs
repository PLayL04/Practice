namespace U_Harchi.Foods.HealthyFoods
{
    internal class Chiken : IHealthyFood
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public Chiken()
        {
            Proteins = true;
            Fats = false;
            Carbohydrates = false;
        }
    }
}
