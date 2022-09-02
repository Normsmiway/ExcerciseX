using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pwes.Domain;
using Pwes.Infrastructure.Components.Processors.BankAccounts;
using Pwes.Infrastructure.Components.Processors.Cards;
using System.Runtime.CompilerServices;

namespace Pwes.Infrastructure.Ioc
{
    public static class Extensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPayemtProcessor, BankAccountPaymentProcessor>();
            services.AddTransient<IPayemtProcessor, CardPaymentProcessor>();
            return services;
        }
    }
}
