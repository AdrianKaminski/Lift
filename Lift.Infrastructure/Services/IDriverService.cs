using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lift.Infrastructure.DTO;

namespace Lift.Infrastructure.Services
{
    public interface IDriverService : IService
    {
        Task<DriverDetailsDto> GetAsync(Guid userId);
        Task<IEnumerable<DriverDto>> BrowseAsync();
        Task CreateAsync(Guid userId);
        Task SetVehicle(Guid userId, string brand, string name);
        Task DeleteAsync(Guid userId);
    }
}