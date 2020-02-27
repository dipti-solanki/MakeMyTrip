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

namespace MakeMyTrip.Domain.SignInModule
{
    public class SignInDomain : ISignInDomain
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SignInDomain(ISignInUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(AppUser parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(AppUser parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(AppUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(AppUser entity)
        {
            await DbContextManager.BeginTransactionAsync();
            var spParameters = new SqlParameter[3];
            spParameters[0] = new SqlParameter() { ParameterName = "EmailId", Value = entity.EmailId };
            spParameters[1] = new SqlParameter() { ParameterName = "MobileNumber", Value =entity.MobileNumber };
            spParameters[2] = new SqlParameter() { ParameterName = "Password", Value =entity.AppPassword };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spSignIn", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch(Exception e)
            {
               DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(AppUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(AppUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(AppUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(AppUser parameters)
        {
            throw new NotImplementedException();
        }

        public ISignInUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ISignInDomain : ICoreDomain<AppUser, AppUser> { }
}
