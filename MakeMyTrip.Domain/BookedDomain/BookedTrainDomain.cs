using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.BookedModule
{
    public class BookedTrainDomain : IBookedTrainDomain
    {
        public BookedTrainDomain(IBookedTrainUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vBookedTrain parameters)
        {
            return await Uow.Repository<vBookedTrain>().FindByAsync(t => t.TravellerId == parameters.TravellerId && t.TrainId == parameters.TrainId);
            
        }

        public async Task<object> GetBy(vBookedTrain parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vBookedTrain entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vBookedTrain entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vBookedTrain entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vBookedTrain entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vBookedTrain parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vBookedTrain parameters)
        {
            throw new NotImplementedException();
        }

        public IBookedTrainUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IBookedTrainDomain : ICoreDomain<vBookedTrain, vBookedTrain> { }
}
