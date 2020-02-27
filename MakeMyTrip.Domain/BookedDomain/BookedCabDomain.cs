using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.BookedModule
{
    public class BookedCabDomain : IBookedCabDomain
    {
        public BookedCabDomain(IBookedCabUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vBookedCab parameters)
        {
            return await Uow.Repository<vBookedCab>().FindByAsync(t => t.TravellerId == parameters.TravellerId && t.CabId == parameters.CabId);
            
        }

        public async Task<object> GetBy(vBookedCab parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vBookedCab entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vBookedCab entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vBookedCab entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vBookedCab entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vBookedCab parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vBookedCab parameters)
        {
            throw new NotImplementedException();
        }

        public IBookedCabUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IBookedCabDomain : ICoreDomain<vBookedCab, vBookedCab> { }
}
