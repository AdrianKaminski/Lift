using System.Threading.Tasks;

namespace Lift.Infrastructure.Services
{
    public interface IRouteManager : IService
    {
        Task<string> GetAddressAsync(double latitude, double longitue);
        double CalculateLength(double startLatitude, double startLongitude,
            double endLatitude, double endLongitude);
    }
}