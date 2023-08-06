using Microsoft.AspNetCore.Mvc;
using SISBackoffice.Application.Services.Authentication;
using SISBackoffice.Contracts.Authentication;

namespace SISBackoffice.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public Task<IActionResult> Register(RegisterRequest request)
    {
        var result = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        var response = new AuthenticationResponse(
            result.BackofficeUser.Id,
            result.BackofficeUser.FirstName,
            result.BackofficeUser.LastName,
            result.BackofficeUser.Email,
            result.Token);
        
        return Task.FromResult<IActionResult>(Ok(response));
    }

    [HttpPost("login")]
    public Task<IActionResult> Login(LoginRequest request)
    {
        var result = _authenticationService.Login(
            request.Email,
            request.Password);

        var response = new AuthenticationResponse(
            result.BackofficeUser.Id,
            result.BackofficeUser.FirstName,
            result.BackofficeUser.LastName,
            result.BackofficeUser.Email,
            result.Token);
        
        return Task.FromResult<IActionResult>(Ok(response));
    }
}