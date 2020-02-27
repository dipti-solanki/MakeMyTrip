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
    public class SearchFilterHotelsController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchFilterHotelsController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[9];
            spParameters[0] = new SqlParameter() { ParameterName = "5Star", Value = searchParams["5Star"] };
            spParameters[1] = new SqlParameter() { ParameterName = "4Star", Value = searchParams["4Star"] };
            spParameters[2] = new SqlParameter() { ParameterName = "3Star", Value = searchParams["3Star"] };
            spParameters[3] = new SqlParameter() { ParameterName = "2Star", Value = searchParams["2Star"] };
            spParameters[4] = new SqlParameter() { ParameterName = "1Star", Value = searchParams["1Star"] };
            spParameters[5] = new SqlParameter() { ParameterName = "Unrated", Value = searchParams["Unrated"] };
            spParameters[6] = new SqlParameter() { ParameterName = "Excellent", Value = searchParams["Excellent"] };
            spParameters[7] = new SqlParameter() { ParameterName = "VeryGood", Value = searchParams["VeryGood"] };
            spParameters[8] = new SqlParameter() { ParameterName = "Good", Value = searchParams["Good"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spFilterHotels", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
