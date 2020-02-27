using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.BookedModule
{
    public class BookedFlightDomain : IBookedFlightDomain
    {
        public BookedFlightDomain(IBookedFlightUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vBookedFlight parameters)
        {
            return await Uow.Repository<vBookedFlight>().FindByAsync(t => t.TravellerId == parameters.TravellerId && t.FlightId == parameters.FlightId);
        }

        public async Task<object> GetBy(vBookedFlight parameters)
        {
           
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vBookedFlight entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vBookedFlight entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vBookedFlight entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vBookedFlight entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vBookedFlight parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vBookedFlight parameters)
        {
            throw new NotImplementedException();
        }

        public IBookedFlightUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IBookedFlightDomain : ICoreDomain<vBookedFlight, vBookedFlight> { }
}
