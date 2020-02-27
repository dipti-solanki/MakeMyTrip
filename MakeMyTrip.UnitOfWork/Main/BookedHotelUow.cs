using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.Main;

namespace MakeMyTrip.UnitOfWork.Main
{
    public class BookedHotelUow : BaseUow, IBookedHotelUow
    {
        public BookedHotelUow(IBookedHotelContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IBookedHotelUow : ICoreUnitOfWork { }
}


