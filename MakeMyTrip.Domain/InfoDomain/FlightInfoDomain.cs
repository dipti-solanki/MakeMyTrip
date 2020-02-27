using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.InfoModule
{
    public class FlightInfoDomain : IFlightInfoDomain
    {
        public FlightInfoDomain(IFlightInfoUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vFlightDetail parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vFlightDetail parameters)
        {
            return await Uow.Repository<vFlightDetail>().FindByAsync(t => t.FlightId == parameters.FlightId);
        }
        

        public HashSet<string> AddValidation(vFlightDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vFlightDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vFlightDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vFlightDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vFlightDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vFlightDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IFlightInfoUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IFlightInfoDomain : ICoreDomain<vFlightDetail,vFlightDetail> { }
}
