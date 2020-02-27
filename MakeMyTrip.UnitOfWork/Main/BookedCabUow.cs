using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class BookedCabUow : BaseUow, IBookedCabUow
    {
        public BookedCabUow(IBookedCabContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookedCabUow : ICoreUnitOfWork { }
}


