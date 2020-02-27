using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.InfoModule
{
    public class BusInfoDomain : IBusInfoDomain
    {
        public BusInfoDomain(IBusInfoUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vBusDetail parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vBusDetail parameters)
        {
            return await Uow.Repository<vBusDetail>().FindByAsync(t => t.BusId == parameters.BusId);
        }
        

        public HashSet<string> AddValidation(vBusDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vBusDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vBusDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vBusDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vBusDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vBusDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IBusInfoUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IBusInfoDomain : ICoreDomain<vBusDetail,vBusDetail> { }
}
