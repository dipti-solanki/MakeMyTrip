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
    public class SearchGetHotelDetailController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchGetHotelDetailController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[1];
            spParameters[0] = new SqlParameter() { ParameterName = "CityId", Value = searchParams["CityId"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spGetHotelDetails", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
