using HomeWork7.Models;

namespace HomeWork7.Repositories
{
    internal class GiftsRepository : IGiftsRepository
    {
        private static GiftsRepository instance;

        private GiftsRepository() { }

        public static GiftsRepository Instance()
        {
            if (instance == null)
            {
                instance = new GiftsRepository();
            }
            return instance;
        }

        private Sweet[] _gift;
        public Sweet[] GetGift()
        {
            return _gift;
        }

        public void PutGift(Sweet[] gift)
        {
            _gift = gift;
        }
    }
}
