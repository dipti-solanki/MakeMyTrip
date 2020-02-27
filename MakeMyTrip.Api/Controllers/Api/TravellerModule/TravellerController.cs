using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MakeMyTrip.Domain.TravellerModule;
using MakeMyTrip.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace MakeMyTrip.Api.Controllers.TravellerModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class TravellerController : BaseDomainController<Traveller,Traveller>

    {
        public TravellerController(ITravellerDomain domain):base(domain) {}

    }
}
