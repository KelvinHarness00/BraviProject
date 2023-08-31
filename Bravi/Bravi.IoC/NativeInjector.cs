using Bravi.Application.Interfaces;
using Bravi.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bravi.IoC
{
    public static class NativeInjector
    {
        public static void RegisterService(IServiceCollection services) 
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}