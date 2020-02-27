using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class BookedTrainUow : BaseUow, IBookedTrainUow
    {
        public BookedTrainUow(IBookedTrainContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookedTrainUow : ICoreUnitOfWork { }
}


