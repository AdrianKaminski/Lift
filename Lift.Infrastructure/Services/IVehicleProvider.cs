using System.Collections.Generic;
using System.Threading.Tasks;
using Lift.Core.Domain;
using Lift.Infrastructure.DTO;

namespace Lift.Infrastructure.Services
{
    public interface IVehicleProvider : IService
    {
        Task<IEnumerable<VehicleDto>> BrowseAsync();
        Task<VehicleDto> GetAsync(string brand, string name);
    }
}