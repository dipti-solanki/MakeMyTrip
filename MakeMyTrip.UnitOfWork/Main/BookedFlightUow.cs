using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class BookedFlightUow : BaseUow, IBookedFlightUow
    {
        public BookedFlightUow(IBookedFlightContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookedFlightUow : ICoreUnitOfWork { }
}


