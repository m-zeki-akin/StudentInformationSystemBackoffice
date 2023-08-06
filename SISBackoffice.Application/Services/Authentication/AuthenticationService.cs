using SISBackoffice.Application.Common.Interfaces.Authentication;
using SISBackoffice.Application.Services.Persistence;
using SISBackoffice.Domain.Entities;

namespace SISBackoffice.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(
        IJwtTokenGenerator jwtTokenGenerator,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Login(string email, string password)
    {
        if (_userRepository.GetUserByEmail(email) is not BackofficeUser user)
        {
            throw new Exception("User with given email does not exists.");
        }

        if (user.Password != password)
        {
            throw new Exception("Invalid Password.");
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }

    public AuthenticationResult Register(
        string firstName,
        string lastName,
        string email,
        string password)
    {
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User with given email is already exists.");
        }

        var user = new BackofficeUser
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        _userRepository.Add(user);

        Guid userId = Guid.NewGuid();

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }
}