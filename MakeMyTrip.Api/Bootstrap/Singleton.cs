using Microsoft.Extensions.DependencyInjection;
using MakeMyTrip.Infrastructure.Singleton;
using MakeMyTrip.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace MakeMyTrip.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




