using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Commander.Installers.Config
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services,  IConfiguration configuration);
    }
}