using HomeWork7.Models;
using HomeWork7.Repositories;

namespace HomeWork7.Services
{
    internal class FindSweetService : IFindSweetService
    {
        public Sweet? FindSweetByName(string? sweetName)
        {
            Sweet[] gift = GiftsRepository.Instance().GetGift();

            for (int i = 0; i < gift.Length; i++)
            {
                if (gift[i].Name == sweetName)
                {
                    return gift[i];
                }
            }
            return null;
        }
    }
}
