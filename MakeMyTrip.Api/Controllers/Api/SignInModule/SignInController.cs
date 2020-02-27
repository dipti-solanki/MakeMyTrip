using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MakeMyTrip.Domain.SignInModule;
using MakeMyTrip.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using RxWeb.Core.Data;
using MakeMyTrip.BoundedContext.SqlContext;

namespace MakeMyTrip.Api.Controllers.SignInModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class SignInController : BaseDomainController<AppUser, AppUser>

    {
       
        public SignInController(ISignInDomain domain) :base(domain) {
        }

    }
}
