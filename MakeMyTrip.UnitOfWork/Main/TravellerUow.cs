using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class TravellerUow : BaseUow, ITravellerUow
    {
        public TravellerUow(ITravellerContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ITravellerUow : ICoreUnitOfWork { }
}


