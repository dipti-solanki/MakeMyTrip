using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class SignInUow : BaseUow, ISignInUow
    {
        public SignInUow(ISignInContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ISignInUow : ICoreUnitOfWork { }
}


