using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MakeMyTrip.BoundedContext.SqlContext;
using MakeMyTrip.Models.Main;
using MakeMyTrip.Models;
using MakeMyTrip.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace MakeMyTrip.BoundedContext.Main
{
    public class HotelInfoContext : BaseBoundedContext, IHotelInfoContext
    {
        public HotelInfoContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<vHotelDetail> vHotelDetails { get; set; }
            #endregion DbSets


    }


    public interface IHotelInfoContext : IDbContext
    {
    }
}

