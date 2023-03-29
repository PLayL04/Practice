namespace U_Harchi.Foods.HealthyFoods
{
    internal class OliveOil : IHealthyFood
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public OliveOil()
        {
            Proteins = false;
            Fats = true;
            Carbohydrates = false;
        }
    }
}
