using HomeWork4._1.Config;
using HomeWork4._1.Dtos.Requests;
using HomeWork4._1.Dtos.Responses;
using HomeWork4._1.Services.Abstractions;
using Microsoft.Extensions.Options;

namespace HomeWork4._1.Services;

public class LoginService : ILoginService
{
    private readonly IInternalHttpClientService _httpClientService;
    private readonly ApiOption _options;
    private readonly string _loginApi = "api/login";
    
    public LoginService(
        IInternalHttpClientService httpClientService,
        IOptions<ApiOption> options)
    {
        _httpClientService = httpClientService;
        _options = options.Value;
    }
    
    public async Task<AuthorizationResponse?> LoginUser(string email, string password)
    {
        AuthorizationResponse? result = null;
        try
        {
            result = await _httpClientService.SendAsync<AuthorizationResponse, AuthorizationRequest>(
                $"{_options.Host}{_loginApi}",
                HttpMethod.Post,
                new AuthorizationRequest()
                {
                    Email = email,
                    Password = password
                });

            Console.WriteLine("Successful login");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return result;
    }
}