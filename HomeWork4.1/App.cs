using HomeWork4._1.Services;
using HomeWork4._1.Services.Abstractions;

namespace HomeWork4._1;

public class App
{
    private readonly IUsersService _usersService;
    private readonly ILoginService _loginService;
    private readonly IRegistrationService _registrationService;

    public App(IUsersService usersService,
        ILoginService loginService,
        IRegistrationService registrationService)
    {
        _usersService = usersService;
        _loginService = loginService;
        _registrationService = registrationService;
    }

    public async Task Start()
    {
        await _usersService.ListUsers(2);
        await _usersService.GetUserById(2);
        await _usersService.CreateUser("morpheus", "leader");
        await _usersService.UpdateUser("morpheus", "zion resident");
        await _usersService.DeleteUser(2);
        await _loginService.LoginUser("eve.holt@reqres.in", "cityslicka");
        await _loginService.LoginUser("peter@klaven", "");
        await _registrationService.RegisterUser("eve.holt@reqres.in", "pistol");
        await _registrationService.RegisterUser("sydney@fife", "");
        await _usersService.ListUsersDelay();
    }
}