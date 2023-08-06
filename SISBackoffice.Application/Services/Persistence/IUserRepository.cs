using SISBackoffice.Domain.Entities;

namespace SISBackoffice.Application.Services.Persistence;

public interface IUserRepository
{
    BackofficeUser? GetUserByEmail(string email);
    void Add(BackofficeUser backofficeUser);

}