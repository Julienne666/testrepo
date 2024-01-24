using HomeWork7.Services;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiftService giftService = new GiftService();
            giftService.Run();
        }
    }
}
