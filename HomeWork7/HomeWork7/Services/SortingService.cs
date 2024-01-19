using HomeWork7.Models;

namespace HomeWork7.Services
{
    internal class SortingService : ISortingService
    {
        public Sweet[] SortSweetsByWeight(Sweet[] gift)
        {
            for (int i = 0; i < gift.Length; i++)
            {
                for (int j = i + 1; j < gift.Length; j++)
                {
                    if (gift[i].Weight > gift[j].Weight)
                    {
                        Sweet temp = gift[i];
                        gift[i] = gift[j];
                        gift[j] = temp;
                    }
                }
            }
            return gift;
        }
    }
}
