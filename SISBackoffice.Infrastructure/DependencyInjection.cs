using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SISBackoffice.Application.Common.Interfaces.Authentication;
using SISBackoffice.Application.Services.Persistence;
using SISBackoffice.Infrastructure.Authentication;
using SISBackoffice.Infrastructure.Persistence;

namespace SISBackoffice.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}