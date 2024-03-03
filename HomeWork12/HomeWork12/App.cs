using HomeWork12.Models;
using HomeWork12.Services.Abstractions;

namespace HomeWork12
{
    internal class App(IPhoneBookService phoneBookService)
    {
        public void Run()
        {
            var contacts = phoneBookService.GetContactsByCulture(Models.Culture.English);

            PrintContactsDictionary(contacts);
        }

        private static void PrintContactsDictionary(Dictionary<string, List<Contact>> contacts)
        {
            Console.WriteLine("Contacts:");
            PrintContacts(contacts, "MAIN");
            Console.WriteLine("#");
            PrintContacts(contacts, "SECONDARY");
            Console.WriteLine("0-9");
            PrintContacts(contacts, "NUMERIC");
        }

        private static void PrintContacts(Dictionary<string, List<Contact>> contacts, string contactGroup)
        {
            foreach (var item in contacts.GetValueOrDefault(contactGroup, new List<Contact>()))
            {
                Console.WriteLine($"{item.Name}, {item.Phone}");
            }
        }
    }
}
