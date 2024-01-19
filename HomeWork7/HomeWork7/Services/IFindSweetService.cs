using HomeWork7.Models;

namespace HomeWork7.Services
{
    internal interface IFindSweetService
    {
        public Sweet? FindSweetByName(string? sweetName);
    }
}
