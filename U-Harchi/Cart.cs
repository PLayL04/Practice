using U_Harchi.Foods;
using U_Harchi.Foods.HealthyFoods;
using U_Harchi.Foods.SemiFinishedFoods;
namespace U_Harchi
{
    internal class Cart<T> where T : IFood
    {
        internal List<T> FoodStuffs = new List<T>();
        public void CartBalancing()
        {
            foreach (var f in FoodStuffs)
            {
                
            }
        }
    }
}

