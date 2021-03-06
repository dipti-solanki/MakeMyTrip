using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.BookedModule
{
    public class BookedBusDomain : IBookedBusDomain
    {
        public BookedBusDomain(IBookedBusUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vBookedBus parameters)
        {
            return await Uow.Repository<vBookedBus>().FindByAsync(t => t.TravellerId == parameters.TravellerId && t.BusId == parameters.BusId);
        }


        public Task<object> GetBy(vBookedBus parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vBookedBus entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vBookedBus entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vBookedBus entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vBookedBus entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vBookedBus parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vBookedBus parameters)
        {
            throw new NotImplementedException();
        }

        public IBookedBusUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IBookedBusDomain : ICoreDomain<vBookedBus,vBookedBus> { }
}
