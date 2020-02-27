using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class HotelInfoUow : BaseUow, IHotelInfoUow
    {
        public HotelInfoUow(IHotelInfoContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IHotelInfoUow : ICoreUnitOfWork { }
}


