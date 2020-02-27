using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;
using System.Linq;

namespace MakeMyTrip.Domain.MasterModule
{
    public class HotelDomain : IHotelDomain
    {
        public HotelDomain(IMasterUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vHotelDetail parameters)
        {
            var HotelList = (object)this.Uow.Repository<vHotelDetail>().All();
            return Task.FromResult(HotelList);
        }

        public async Task<object> GetBy(vHotelDetail entity)
        {
            return await Uow.Repository<vHotelDetail>().FindByAsync(t => t.HotelId==entity.HotelId);
        }
        

        public HashSet<string> AddValidation(vHotelDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vHotelDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vHotelDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vHotelDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vHotelDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vHotelDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IMasterUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IHotelDomain : ICoreDomain<vHotelDetail,vHotelDetail> { }
}
