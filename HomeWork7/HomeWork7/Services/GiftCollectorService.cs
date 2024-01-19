using HomeWork7.Models;
using HomeWork7.Repositories;

namespace HomeWork7.Services
{
    internal class GiftCollectorService : IGiftCollectorService
    {
        public void CollectGift()
        {
            ISweetsRepository sweetsRepository = new SweetsRepository();

            Sweet[] gift = new Sweet[20];
            for (int i = 0; i < gift.Length; i++)
            {
                gift[i] = sweetsRepository.GetSweets()[new Random().Next(0, 21)];
            }

            SortingService sortingService = new SortingService();
            sortingService.SortSweetsByWeight(gift);

            Console.WriteLine("Sweets in gift: ");
            foreach(Sweet isweet in gift)
            {
                Console.WriteLine($"{isweet.Name}, {isweet.Weight} grams");
            }

            GiftsRepository.Instance().PutGift(gift);
        }
    }
}
