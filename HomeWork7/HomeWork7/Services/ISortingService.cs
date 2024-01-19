using HomeWork7.Models;

namespace HomeWork7.Services
{
    internal interface ISortingService
    {
        public Sweet[] SortSweetsByWeight(Sweet[] gift);
    }
}
