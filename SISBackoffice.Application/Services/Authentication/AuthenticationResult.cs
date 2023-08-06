using SISBackoffice.Domain.Entities;

namespace SISBackoffice.Application.Services.Authentication;

public record AuthenticationResult(BackofficeUser BackofficeUser,string Token);