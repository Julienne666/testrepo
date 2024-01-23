using HomeWork8.Models;

namespace HomeWork8.Services
{
    internal interface ICalorieCounterService
    {
        public int GetCalories(SaladItem[] salad);
    }
}
