using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class CabInfoUow : BaseUow, ICabInfoUow
    {
        public CabInfoUow(ICabInfoContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ICabInfoUow : ICoreUnitOfWork { }
}


