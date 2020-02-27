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
    public class SearchFilterTrainsController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchFilterTrainsController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[4];
            spParameters[0] = new SqlParameter() { ParameterName = "1stClassAC", Value = searchParams["1stClassAC"] };
            spParameters[1] = new SqlParameter() { ParameterName = "2TierAC", Value = searchParams["2TierAC"] };
            spParameters[2] = new SqlParameter() { ParameterName = "3TierAC", Value = searchParams["3TierAC"] };
            spParameters[3] = new SqlParameter() { ParameterName = "Sleeper", Value = searchParams["Sleeper"] };
           var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spFilterTrains", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
