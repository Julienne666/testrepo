using HomeWork12.Models;

namespace HomeWork12.Repositories.Abstractions
{
    internal interface IContactsRepository
    {
        public List<Contact> GetContacts();
    }
}
