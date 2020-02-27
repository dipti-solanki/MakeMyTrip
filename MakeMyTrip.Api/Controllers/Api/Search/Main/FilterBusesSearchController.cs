using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Security;
using RxWeb.Core.Data;
using MakeMyTrip.Models.ViewModels;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Api.Controllers.Module
{
    [ApiController]
	[Route("api/[controller]")]
    public class SearchFilterBusesController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchFilterBusesController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[6];
            spParameters[0] = new SqlParameter() { ParameterName = "ACSeater", Value = searchParams["ACSeater"] };
            spParameters[1] = new SqlParameter() { ParameterName = "NonACSeater", Value = searchParams["NonACSeater"] };
            spParameters[2] = new SqlParameter() { ParameterName = "ACSleeper", Value = searchParams["ACSleeper"] };
            spParameters[3] = new SqlParameter() { ParameterName = "NonACSleeper", Value = searchParams["NonACSleeper"] };
            spParameters[4] = new SqlParameter() { ParameterName = "StateTransport", Value = searchParams["1Stop"] };
            spParameters[5] = new SqlParameter() { ParameterName = "PublicTransport", Value = searchParams["PublicTransport"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spFilterBuses", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
