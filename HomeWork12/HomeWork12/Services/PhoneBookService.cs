using HomeWork12.Models;
using HomeWork12.Repositories;
using HomeWork12.Repositories.Abstractions;
using HomeWork12.Services.Abstractions;

namespace HomeWork12.Services
{
    internal class PhoneBookService : IPhoneBookService
    {
        private readonly IContactsRepository _contactsRepository;

        public PhoneBookService(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }
        public Dictionary<string, List<Contact>> GetContactsByCulture(Culture culture)
        {
            var rawContacts = _contactsRepository.GetContacts();
            var resultContacts = new Dictionary<string, List<Contact>>();

            switch (culture)
            {
                case Culture.Ukrainian:
                    // find only Latin contacts, sort them and add to result dictionary
                    List<Contact> mainContacts = rawContacts.FindAll(it => it is CyrylicContact).ToList();
                    mainContacts.Sort(new Comparator());
                    resultContacts.Add("MAIN", mainContacts);

                    // find all other contacts except Latin and Numeric and add to result dictionary
                    List<Contact> secondaryContacts = rawContacts.FindAll(it => !(it is CyrylicContact) && !(it is NumericContact)).ToList();
                    resultContacts.Add("SECONDARY", secondaryContacts);

                    // find only Numeric contacts and add to result dictionary
                    List<Contact> numericContacts = rawContacts.FindAll(it => it is NumericContact).ToList();
                    resultContacts.Add("NUMERIC", numericContacts);
                    break;

                default:
                    // find only Latin contacts, sort them and add to result dictionary
                    List<Contact> defaultMainContacts = rawContacts.FindAll(it => it is LatinContact).ToList();
                    defaultMainContacts.Sort(new Comparator());
                    resultContacts.Add("MAIN", defaultMainContacts);

                    // find all other contacts except Latin and Numeric and add to result dictionary
                    List<Contact> defaultSecondaryContacts = rawContacts.FindAll(it => !(it is LatinContact) && !(it is NumericContact)).ToList();
                    resultContacts.Add("SECONDARY", defaultSecondaryContacts);

                    // find only Numeric contacts and add to result dictionary
                    List<Contact> defaultNumericContacts = rawContacts.FindAll(it => it is NumericContact).ToList();
                    resultContacts.Add("NUMERIC", defaultNumericContacts);
                    break;
            }

            return resultContacts;
        }
    }
}
