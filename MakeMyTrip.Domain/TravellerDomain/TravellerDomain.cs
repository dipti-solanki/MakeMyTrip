using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;
using MakeMyTrip.BoundedContext.SqlContext;
using RxWeb.Core.Data;
using Microsoft.Data.SqlClient;
using MakeMyTrip.Models.ViewModels;

namespace MakeMyTrip.Domain.TravellerModule
{
    public class TravellerDomain : ITravellerDomain
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public TravellerDomain(ITravellerUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(Traveller parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(Traveller parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(Traveller entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Traveller entity)
        {
            await DbContextManager.BeginTransactionAsync();
            if(entity.AppUserId == null)
            {
                entity.AppUserId = 0;
            }
            var spParameters = new SqlParameter[5];
            spParameters[0] = new SqlParameter() { ParameterName = "AppUserId", Value = entity.AppUserId };
            spParameters[1] = new SqlParameter() { ParameterName = "FirstName", Value = entity.FirstName};
            spParameters[2] = new SqlParameter() { ParameterName = "LastName", Value = entity.LastName};
            spParameters[3] = new SqlParameter() { ParameterName = "EmailId", Value = entity.EmailId };
            spParameters[4] = new SqlParameter() { ParameterName = "MobileNumber", Value = entity.MobileNumber };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spUser", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch (Exception e)
            {
                DbContextManager.RollbackTransaction();
            }

        }

        public HashSet<string> UpdateValidation(Traveller entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Traveller entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Traveller parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Traveller parameters)
        {
            throw new NotImplementedException();
        }

        public ITravellerUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ITravellerDomain : ICoreDomain<Traveller, Traveller> { }
}
