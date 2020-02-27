using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class FlightInfoUow : BaseUow, IFlightInfoUow
    {
        public FlightInfoUow(IFlightInfoContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IFlightInfoUow : ICoreUnitOfWork { }
}


