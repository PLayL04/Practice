using U_Harchi.Foods.HealthyFoods;
using U_Harchi.Foods.SemiFinishedFoods;
using U_Harchi.Foods.Snacks;
using U_Harchi.Things;

namespace U_Harchi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            U_Harchi u_Harchi = new U_Harchi();
            u_Harchi.Things.Add(new Notebook());
            u_Harchi.Things.Add(new Pen());
            u_Harchi.HealthyFoods.Add(new Chiken());
            u_Harchi.HealthyFoods.Add(new Fruit());
            u_Harchi.HealthyFoods.Add(new OliveOil());
            u_Harchi.SemiFinishedFoods.Add(new Cheburek());
            u_Harchi.SemiFinishedFoods.Add(new DumpligsBerries());
            u_Harchi.SemiFinishedFoods.Add(new DumplingsMeat());
            u_Harchi.Snacks.Add(new BalykCheese());
            u_Harchi.Snacks.Add(new ChocolateBar());
            u_Harchi.Snacks.Add(new Crisps());
        }
    }
}