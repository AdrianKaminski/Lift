using System.Threading.Tasks;

namespace Lift.Infrastructure.Services
{
    public interface IDataInitializer : IService
    {
         Task SeedAsync();
    }
}