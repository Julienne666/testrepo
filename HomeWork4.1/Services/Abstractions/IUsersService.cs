using System.Net;
using HomeWork4._1.Dtos;
using HomeWork4._1.Dtos.Responses;

namespace HomeWork4._1.Services;

public interface IUsersService
{
    Task<List<UserDto>> ListUsers(int page);
    
    Task<List<UserDto>> ListUsersDelay();
    
    Task<UserDto> GetUserById(int id); 
    
    Task<UserResponse> CreateUser(string name, string job);
    
    Task<UserUpdateResponse> UpdateUser(string name, string job);
    
    Task<Object> DeleteUser(int id);
}