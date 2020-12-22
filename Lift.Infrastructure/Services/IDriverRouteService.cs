using System;
using System.Threading.Tasks;
using Lift.Infrastructure.DTO;

namespace Lift.Infrastructure.Services
{
    public interface IDriverRouteService : IService
    {
        Task AddAsync(Guid userId, string name, 
            double startLatitude, double startLongitude,
            double endLatitude, double endLongitude);
        Task DeleteAsync(Guid userId, string name);
  }
}