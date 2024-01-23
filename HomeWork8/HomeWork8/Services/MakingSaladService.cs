using HomeWork8.Models;
using HomeWork8.Repositories;
using System;

namespace HomeWork8.Services
{
    internal class MakingSaladService : IMakingSaladService
    {
        public void MakeSalad()
        {
            Random random = new Random();
            IVegetablesRepository vegetablesRepository = new VegetablesRepository();
            Vegetable[] vegetables = vegetablesRepository.GetVegetables().OrderBy(x => random.Next()).ToArray();


            SaladItem[] salad = new SaladItem[new Random().Next(3, 10)];
            for (int i = 0; i < salad.Length; i++)
            {
                salad[i] = new SaladItem(vegetables[i], (i + 1) * 20);
            }

            Console.WriteLine("Here's your salad: ");
            foreach (SaladItem item in salad)
            {
                Console.WriteLine($"{item.VegetableType.Name}, {item.VegetableMass} gram");
            }

            ICalorieCounterService calorieCounterService = new CalorieCountingService();
            int totalCalories = calorieCounterService.GetCalories(salad);

            Console.WriteLine($"Total calories: {totalCalories} kcal");
            Console.WriteLine("");

            Console.WriteLine("Enter the name of the vegetable and check if it is in our store:");
            var vegetableName = Console.ReadLine();

            IFindVegetableService findVegetable = new FindVegetableService();
            Vegetable? vegetable = findVegetable.FindVegetableByName(vegetableName);
            if (vegetable == null)
            {
                Console.WriteLine("Nothing was found");
            }
            else
            {
                Console.WriteLine($"That`s what we found: {vegetable.Name}, {vegetable.Calories} calories per 100 gram");
            }
        }
    }
}
