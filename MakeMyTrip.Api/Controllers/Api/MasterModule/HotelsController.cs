using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MakeMyTrip.Domain.MasterModule;
using MakeMyTrip.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace MakeMyTrip.Api.Controllers.MasterModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class HotelsController : BaseDomainController<vHotelDetail, vHotelDetail>

    {
        public HotelsController(IHotelDomain domain):base(domain) {}

    }
}
