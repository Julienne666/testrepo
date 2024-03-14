using System.Net;
using HomeWork4._1.Config;
using HomeWork4._1.Dtos;
using HomeWork4._1.Dtos.Requests;
using HomeWork4._1.Dtos.Responses;
using HomeWork4._1.Services.Abstractions;
using Microsoft.Extensions.Options;

namespace HomeWork4._1.Services;

public class UsersService : IUsersService
{
    private readonly IInternalHttpClientService _httpClientService;
    private readonly ApiOption _options;
    private readonly string _userApi = "api/users/";
    private readonly string _userApiDelayed = "api/users?delay=3";
    
    public UsersService(
        IInternalHttpClientService httpClientService,
        IOptions<ApiOption> options)
    {
        _httpClientService = httpClientService;
        _options = options.Value;
    }
    
    public async Task<List<UserDto>> ListUsers(int page)
    {
        var result = await _httpClientService.SendAsync<BaseResponse<List<UserDto>>, Object>(
            $"{_options.Host}{_userApi}?page={page}",
            HttpMethod.Get
        );

        result.Data.ForEach( dto => Console.WriteLine(dto.FirstName));
        Console.WriteLine();
        
        return result.Data;
    }

    public async Task<List<UserDto>> ListUsersDelay()
    {
        var result = await _httpClientService.SendAsync<BaseResponse<List<UserDto>>, Object>(
            $"{_options.Host}{_userApiDelayed}",
            HttpMethod.Get
        );

        result.Data.ForEach( dto => Console.WriteLine(dto.FirstName));
        Console.WriteLine();
        
        return result.Data;
    }

    public async Task<UserDto> GetUserById(int id)
    {
        var result = await _httpClientService.SendAsync<BaseResponse<UserDto>, Object>(
            $"{_options.Host}{_userApi}{id}",
            HttpMethod.Get
        );

        Console.WriteLine(result.Data.FirstName);

        return result.Data;
    }

    public async Task<UserResponse> CreateUser(string name, string job)
    {
        var result = await _httpClientService.SendAsync<UserResponse, UserRequest>(
            $"{_options.Host}{_userApi}",
            HttpMethod.Post,
            new UserRequest()
            {
                Job = job,
                Name = name
            });

        Console.WriteLine($"User with id = {result.Id} was created");

        return result;
    }

    public async Task<UserUpdateResponse> UpdateUser(string name, string job)
    {
        var result = await _httpClientService.SendAsync<UserUpdateResponse, UserRequest>(
            $"{_options.Host}{_userApi}",
            HttpMethod.Put,
            new UserRequest()
            {
                Job = job,
                Name = name
            });
        
        Console.WriteLine($"User with name = {result.Name} was updated");

        return result;
    }

    public async Task<Object> DeleteUser(int id)
    {
        var result = await _httpClientService.SendAsync<Object, Object>(
            $"{_options.Host}{_userApi}{id}",
            HttpMethod.Delete
        );
        
        Console.WriteLine($"User with id = {id} was deleted");

        return result;
    }
}