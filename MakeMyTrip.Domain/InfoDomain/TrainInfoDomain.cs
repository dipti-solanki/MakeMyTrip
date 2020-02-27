using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MakeMyTrip.UnitOfWork.Main;
using MakeMyTrip.Models.Main;

namespace MakeMyTrip.Domain.InfoModule
{
    public class TrainInfoDomain : ITrainInfoDomain
    {
        public TrainInfoDomain(ITrainInfoUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vTrainDetail parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vTrainDetail parameters)
        {
            return await Uow.Repository<vTrainDetail>().FindByAsync(t => t.TrainId == parameters.TrainId);
        }
        

        public HashSet<string> AddValidation(vTrainDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vTrainDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vTrainDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vTrainDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vTrainDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vTrainDetail parameters)
        {
            throw new NotImplementedException();
        }

        public ITrainInfoUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ITrainInfoDomain : ICoreDomain<vTrainDetail, vTrainDetail> { }
}
