
using APISERVI.Repository;
using APISERVI.Repository.Application;

namespace APISERVI.Infrastructure;
public static class ServiceCollectionExtension
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddTransient<IVehiculoRepository, VehiculoRepository>();
        services.AddTransient<IConductoresRepository, ConductoresRepository>();
    
    }
}