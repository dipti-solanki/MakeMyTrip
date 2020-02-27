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
    public class SearchFilterFlightsController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchFilterFlightsController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[6];
            spParameters[0] = new SqlParameter() { ParameterName = "AirIndia",  Value = searchParams ["AirIndia"] };
            spParameters[1] = new SqlParameter() { ParameterName = "IndianAriways",Value = searchParams["IndianAriways"] };
            spParameters[2] = new SqlParameter() { ParameterName = "Spicejet", Value = searchParams["Spicejet"] };
            spParameters[3] = new SqlParameter() { ParameterName = "Airgo", Value =searchParams["Airgo"] };
            spParameters[4] = new SqlParameter() { ParameterName = "1Stop", Value = searchParams["1Stop"] };
            spParameters[5] = new SqlParameter() { ParameterName = "NonStop", Value =searchParams["NonStop"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spFilterFlights", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
