using Microsoft.Extensions.DependencyInjection;
using SISBackoffice.Application.Services.Authentication;

namespace SISBackoffice.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        
        return services;
    }
}