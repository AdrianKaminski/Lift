using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lift.Core.Domain;

namespace Lift.Core.Repositories
{
    public interface IDriverRepository : IRepository
    {
        Task<Driver> GetAsync(Guid userId); 
        Task<IEnumerable<Driver>> GetAllAsync();
        Task AddAsync(Driver driver);
        Task UpdateAsync(Driver driver);
        Task DeleteAsync(Driver driver);
    }
}