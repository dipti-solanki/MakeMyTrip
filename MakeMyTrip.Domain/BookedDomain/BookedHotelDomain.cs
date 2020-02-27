using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.BookedModule
{
    public class BookedHotelDomain : IBookedHotelDomain
    {
        public BookedHotelDomain(IBookedHotelUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vBookedHotel parameters)
        {
            return await Uow.Repository<vBookedHotel>().FindByAsync(t => t.TravellerId == parameters.TravellerId && t.HotelId == parameters.HotelId);
        }

        public Task<object> GetBy(vBookedHotel parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vBookedHotel entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vBookedHotel entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vBookedHotel entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vBookedHotel entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vBookedHotel parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vBookedHotel parameters)
        {
            throw new NotImplementedException();
        }

        public IBookedHotelUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IBookedHotelDomain : ICoreDomain<vBookedHotel, vBookedHotel> { }
}
