using SISBackoffice.Application.Services.Persistence;
using SISBackoffice.Domain.Entities;

namespace SISBackoffice.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private readonly List<BackofficeUser> _users = new();

    public BackofficeUser? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }

    public void Add(BackofficeUser backofficeUser)
    {
        _users.Add(backofficeUser);
    }
}