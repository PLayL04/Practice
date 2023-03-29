namespace U_Harchi.Foods.HealthyFoods
{
    internal class Fruit : IHealthyFood
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public Fruit()
        {
            Proteins = false;
            Fats = false;
            Carbohydrates = true;
        }
    }
}
