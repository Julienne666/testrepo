using HomeWork4._1.Dtos.Responses;

namespace HomeWork4._1.Services.Abstractions;

public interface ILoginService
{
    Task<AuthorizationResponse?> LoginUser(string email, string password);
}