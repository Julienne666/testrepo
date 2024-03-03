using HomeWork12.Models;
using HomeWork12.Repositories.Abstractions;

namespace HomeWork12.Repositories
{
    internal class ContactsRepository : IContactsRepository
    {
        private List<Contact> _contacts;
        public ContactsRepository()
        {
            _contacts =
                [
                    new CyrylicContact("Спайдермен", "+380505551111"),
                    new CyrylicContact("Тор", "+380505551112"),
                    new CyrylicContact("Айронмен", "+380505551113"),
                    new CyrylicContact("Бетмен", "+380505551114"),
                    new CyrylicContact("Супермен", "+380505551115"),
                    new CyrylicContact("Харлі Квін", "+380505551116"),
                    new CyrylicContact("Халк", "+380505551117"),
                    new CyrylicContact("Доктор Стрендж", "+380505551118"),
                    new CyrylicContact("Локі", "+380505551119"),
                    new CyrylicContact("Джокер", "+380505551110"),
                    new LatinContact("Lilly", "+380977771111"),
                    new LatinContact("Jenifer", "+380977771112"),
                    new LatinContact("Andrew", "+380977771113"),
                    new LatinContact("Bill", "+380977771114"),
                    new LatinContact("Holly", "+380977771115"),
                    new LatinContact("Sam", "+380977771116"),
                    new LatinContact("Peter", "+380977771117"),
                    new LatinContact("Leks", "+380977771118"),
                    new LatinContact("Lana", "+380977771119"),
                    new LatinContact("Klark", "+380977771110"),
                    new NumericContact("", "+380633331111"),
                    new NumericContact("", "+380633331112"),
                    new NumericContact("", "+380633331113"),
                    new NumericContact("", "+380633331114"),
                    new NumericContact("", "+380633331115")
                ];
        }
        public List<Contact> GetContacts()
        {
            return _contacts;
        }
    }
}
