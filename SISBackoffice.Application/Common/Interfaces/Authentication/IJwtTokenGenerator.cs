using SISBackoffice.Domain.Entities;

namespace SISBackoffice.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(BackofficeUser user);
}