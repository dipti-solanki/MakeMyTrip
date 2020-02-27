using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MakeMyTrip.Domain.BookedModule;
using MakeMyTrip.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace MakeMyTrip.Api.Controllers.BookedModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class BookedHotelController : BaseDomainController<vBookedHotel,vBookedHotel>

    {
        public BookedHotelController(IBookedHotelDomain domain):base(domain) {}

    }
}
