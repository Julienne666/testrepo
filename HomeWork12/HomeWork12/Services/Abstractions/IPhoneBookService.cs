using HomeWork12.Models;

namespace HomeWork12.Services.Abstractions
{
    internal interface IPhoneBookService
    {
        public Dictionary<string, List<Contact>> GetContactsByCulture(Culture culture);
    }
}
