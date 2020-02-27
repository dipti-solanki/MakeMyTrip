using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MakeMyTrip.Domain.InfoModule;
using MakeMyTrip.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace MakeMyTrip.Api.Controllers.InfoModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class CabInfoController : BaseDomainController<vCabDetail, vCabDetail>

    {
        public CabInfoController(ICabInfoDomain domain):base(domain) {}

    }
}
