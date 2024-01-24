using HomeWork7.Models;

namespace HomeWork7.Repositories
{
    internal interface IGiftsRepository
    {
        public void PutGift(Sweet[] sweets);
        public Sweet[] GetGift();
    }
}