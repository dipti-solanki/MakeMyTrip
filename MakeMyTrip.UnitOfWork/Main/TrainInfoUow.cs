using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class TrainInfoUow : BaseUow, ITrainInfoUow
    {
        public TrainInfoUow(ITrainInfoContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ITrainInfoUow : ICoreUnitOfWork { }
}


