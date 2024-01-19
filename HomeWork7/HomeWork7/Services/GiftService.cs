using HomeWork7.Models;
using HomeWork7.Repositories;

namespace HomeWork7.Services
{
    internal class GiftService : IGiftService
    {
        public void Run()
        {
            GiftCollectorService giftCollector = new GiftCollectorService();
            giftCollector.CollectGift();

            Console.WriteLine("What sweet are you looking for?");
            var sweetName = Console.ReadLine();

            FindSweetService findSweet = new FindSweetService();
            Sweet? sweet = findSweet.FindSweetByName(sweetName);
            if (sweet == null)
            {
                Console.WriteLine("Nothing was found");
            }
            else
            {
                Console.WriteLine($"That`s what we found: {sweet.Name}, {sweet.Weight} gram, ingridients: {sweet.GetIngridients()}");
            }
        }
    }
}
