using HomeWork4._1.Dtos.Responses;

namespace HomeWork4._1.Services.Abstractions;

public interface IRegistrationService
{
    Task<RegistrationResponse?> RegisterUser(string email, string password);
}