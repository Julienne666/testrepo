using HomeWork12.Models;
using System.Diagnostics;

namespace HomeWork12.Services
{
    internal class Comparator : IComparer<Contact>
    {
        public int Compare(Contact contact1, Contact contact2)
        {
            if (contact1.Name[0] < contact2.Name[0])
            {
                return -1;
            }
            else if (contact1.Name[0] > contact2.Name[0])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
