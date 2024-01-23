using HomeWork8.Models;

namespace HomeWork8.Services
{
    internal class CalorieCountingService : ICalorieCounterService
    {
        public int GetCalories(SaladItem[] salad)
        {
            int totalCalories = 0;

            foreach (SaladItem item in salad)
            {
                int mass = item.VegetableMass;
                int callories = item.VegetableType.Calories;
                int itemcalories = mass * callories / 100;
                totalCalories += itemcalories;
            }
            return totalCalories;
        }
    }
}
