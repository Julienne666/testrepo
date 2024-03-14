using HomeWork4._1.Config;
using HomeWork4._1.Dtos.Requests;
using HomeWork4._1.Dtos.Responses;
using HomeWork4._1.Services.Abstractions;
using Microsoft.Extensions.Options;

namespace HomeWork4._1.Services;

public class RegistrationService : IRegistrationService
{
    private readonly IInternalHttpClientService _httpClientService;
    private readonly ApiOption _options;
    private readonly string _registrationApi = "api/register";
    
    public RegistrationService(
        IInternalHttpClientService httpClientService,
        IOptions<ApiOption> options)
    {
        _httpClientService = httpClientService;
        _options = options.Value;
    }
    
    public async Task<RegistrationResponse?> RegisterUser(string email, string password)
    {
        RegistrationResponse? result = null;
        try
        {
            result = await _httpClientService.SendAsync<RegistrationResponse, AuthorizationRequest>(
                $"{_options.Host}{_registrationApi}",
                HttpMethod.Post,
                new AuthorizationRequest()
                {
                    Email = email,
                    Password = password
                });

            Console.WriteLine("Successful registration");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return result;
    }
}