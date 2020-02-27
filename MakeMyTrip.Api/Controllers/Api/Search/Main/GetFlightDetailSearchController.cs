using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Security;
using RxWeb.Core.Data;

using MakeMyTrip.Models.ViewModels;
using MakeMyTrip.BoundedContext.SqlContext;
using MakeMyTrip.Models.Main;
using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json.Linq;

namespace MakeMyTrip.Api.Controllers.Module
{
    [ApiController]
	[Route("api/[controller]")]
    public class SearchGetFlightDetailController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchGetFlightDetailController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string, string> searchParams)
        {
            SqlParameter[] spParameters = new SqlParameter[3];
            spParameters[0] = new SqlParameter() { ParameterName = "origin", Value = searchParams["origin"] };
            spParameters[1] = new SqlParameter() { ParameterName = "destination", Value = searchParams["destination"] };
            spParameters[2] = new SqlParameter() { ParameterName = "date", Value = searchParams["date"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spGetFlightDetails", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
