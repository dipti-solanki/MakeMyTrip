using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class BookedBusUow : BaseUow, IBookedBusUow
    {
        public BookedBusUow(IBookedBusContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookedBusUow : ICoreUnitOfWork { }
}


