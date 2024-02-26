List<string> contactList = new List<string> { "Alice", "Bob", "Charlie", "David", "Emily" };

string firstContact = contactList.FirstOrDefault();
Console.WriteLine("First contact: " + firstContact);

var contactsStartingWithB = contactList.Where(c => c.StartsWith("B"));
Console.WriteLine("Contacts starting with 'B': " + string.Join(", ", contactsStartingWithB));

var uppercaseContacts = contactList.Select(c => c.ToUpper());
Console.WriteLine("Uppercase contacts: " + string.Join(", ", uppercaseContacts));

var sortedContacts = contactList.OrderBy(c => c);
Console.WriteLine("Sorted contacts: " + string.Join(", ", sortedContacts));

var groupedContacts = contactList.GroupBy(c => c.Length);
foreach (var group in groupedContacts)
{
    Console.WriteLine($"Contacts with length {group.Key}: {string.Join(", ", group)}");
}

bool hasContacts = contactList.Any();
Console.WriteLine("Has contacts: " + hasContacts);