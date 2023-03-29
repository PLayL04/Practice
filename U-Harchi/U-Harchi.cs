using U_Harchi.Foods.HealthyFoods;
using U_Harchi.Foods.SemiFinishedFoods;
using U_Harchi.Foods.Snacks;
using U_Harchi.Things;

namespace U_Harchi
{
    internal class U_Harchi
    {
        public List<IThing> Things = new List<IThing>();
        public List<IHealthyFood> HealthyFoods = new List<IHealthyFood>();
        public List<ISemiFinishedFood> SemiFinishedFoods = new List<ISemiFinishedFood>();
        public List<ISnack> Snacks = new List<ISnack>();
    }
}
