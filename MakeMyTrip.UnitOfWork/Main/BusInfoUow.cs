using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class BusInfoUow : BaseUow, IBusInfoUow
    {
        public BusInfoUow(IBusInfoContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBusInfoUow : ICoreUnitOfWork { }
}


