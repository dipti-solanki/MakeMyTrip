using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.InfoModule
{
    public class CabInfoDomain : ICabInfoDomain
    {
        public CabInfoDomain(ICabInfoUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vCabDetail parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vCabDetail parameters)
        {
            return await Uow.Repository<vCabDetail>().FindByAsync(t => t.CabId == parameters.CabId);
        }
        

        public HashSet<string> AddValidation(vCabDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vCabDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vCabDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vCabDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vCabDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vCabDetail parameters)
        {
            throw new NotImplementedException();
        }

        public ICabInfoUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ICabInfoDomain : ICoreDomain<vCabDetail, vCabDetail> { }
}
