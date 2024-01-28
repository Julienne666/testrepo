using HomeWork8.Models;
using HomeWork8.Repositories;

namespace HomeWork8.Services
{
    internal class FindVegetableService : IFindVegetableService
    {
        public Vegetable? FindVegetableByName(string? vegetableName)
        {
            VegetablesRepository vegetablesRepository = new VegetablesRepository();

            Vegetable[] vegetable = vegetablesRepository.GetVegetables();

            for (int i = 0; i < vegetable.Length; i++)
            {
                if (vegetable[i].Name == vegetableName)
                {
                    return vegetable[i];
                }
            }
            return null;
        }
    }
}
