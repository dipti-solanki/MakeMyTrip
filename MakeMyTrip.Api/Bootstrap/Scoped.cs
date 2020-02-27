#region Namespace
using Microsoft.Extensions.DependencyInjection;
using MakeMyTrip.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using MakeMyTrip.UnitOfWork.DbEntityAudit;
using MakeMyTrip.BoundedContext.Main;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Domain.MasterModule;
            using MakeMyTrip.Domain;

            using MakeMyTrip.Domain.SignInModule;
         
         
            using MakeMyTrip.Domain.InfoModule;
            using MakeMyTrip.Domain.TravellerModule;
            using MakeMyTrip.Domain.BookedModule;
            #endregion Namespace





namespace MakeMyTrip.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
                        serviceCollection.AddScoped<IMasterContext, MasterContext>();
            serviceCollection.AddScoped<IMasterUow, MasterUow>();
                        serviceCollection.AddScoped<ISignInContext, SignInContext>();
            serviceCollection.AddScoped<ISignInUow, SignInUow>();
                        serviceCollection.AddScoped<ISignInContext, SignInContext>();
            serviceCollection.AddScoped<ISignInUow, SignInUow>();
                        serviceCollection.AddScoped<ISignInContext, SignInContext>();
            serviceCollection.AddScoped<ISignInUow, SignInUow>();
                        serviceCollection.AddScoped<ISignInContext, SignInContext>();
            serviceCollection.AddScoped<ISignInUow, SignInUow>();
                      
           
                        serviceCollection.AddScoped<IFlightInfoContext, FlightInfoContext>();
            serviceCollection.AddScoped<IFlightInfoUow, FlightInfoUow>();
                        serviceCollection.AddScoped<ITrainInfoContext, TrainInfoContext>();
            serviceCollection.AddScoped<ITrainInfoUow, TrainInfoUow>();
                        serviceCollection.AddScoped<ICabInfoContext, CabInfoContext>();
            serviceCollection.AddScoped<ICabInfoUow, CabInfoUow>();
                        serviceCollection.AddScoped<IBusInfoContext, BusInfoContext>();
            serviceCollection.AddScoped<IBusInfoUow, BusInfoUow>();
                        serviceCollection.AddScoped<ITravellerContext, TravellerContext>();
            serviceCollection.AddScoped<ITravellerUow, TravellerUow>();
                        serviceCollection.AddScoped<IBookedFlightContext, BookedFlightContext>();
            serviceCollection.AddScoped<IBookedFlightUow, BookedFlightUow>();
                        serviceCollection.AddScoped<IBookedCabContext, BookedCabContext>();
            serviceCollection.AddScoped<IBookedCabUow, BookedCabUow>();
                        serviceCollection.AddScoped<IBookedTrainContext, BookedTrainContext>();
            serviceCollection.AddScoped<IBookedTrainUow, BookedTrainUow>();
                      
            
            serviceCollection.AddScoped<IBookedBusContext, BookedBusContext>();
            serviceCollection.AddScoped<IBookedBusUow, BookedBusUow>();
                        serviceCollection.AddScoped<IHotelInfoContext, HotelInfoContext>();
            serviceCollection.AddScoped<IHotelInfoUow, HotelInfoUow>();
                        serviceCollection.AddScoped<IBookedHotelContext, BookedHotelContext>();
            serviceCollection.AddScoped<IBookedHotelUow, BookedHotelUow>();
            #endregion ContextService






















            #region DomainService
       
            serviceCollection.AddScoped<IHotelDomain, HotelDomain>();
          
          
            serviceCollection.AddScoped<IHotelDomain, HotelDomain>();
            
            
            
            serviceCollection.AddScoped<ISignInDomain, SignInDomain>();
            
       
            
           
            
            serviceCollection.AddScoped<IFlightInfoDomain, FlightInfoDomain>();
            
            serviceCollection.AddScoped<ITrainInfoDomain, TrainInfoDomain>();
            
            serviceCollection.AddScoped<ICabInfoDomain, CabInfoDomain>();
            
            serviceCollection.AddScoped<IBusInfoDomain, BusInfoDomain>();
            
            serviceCollection.AddScoped<ITravellerDomain, TravellerDomain>();
            
            serviceCollection.AddScoped<IBookedFlightDomain, BookedFlightDomain>();
            
            serviceCollection.AddScoped<IBookedCabDomain, BookedCabDomain>();
            
            serviceCollection.AddScoped<IBookedTrainDomain, BookedTrainDomain>();
          
            serviceCollection.AddScoped<IBookedBusDomain, BookedBusDomain>();
            
            serviceCollection.AddScoped<IBookedHotelDomain, BookedHotelDomain>();
            #endregion DomainService
























        }
    }
}