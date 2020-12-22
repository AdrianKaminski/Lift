using System.Threading.Tasks;
using Lift.Infrastructure.Commands;
using Lift.Infrastructure.Commands.Drivers;
using Lift.Infrastructure.Services;

namespace Lift.Infrastructure.Handlers.Drivers
{
    public class UpdateDriverHandler : ICommandHandler<UpdateDriver>
    {
        private readonly IDriverService _driverService;

        public UpdateDriverHandler(IDriverService driverService)
        {
            _driverService = driverService;
        }

        public async Task HandleAsync(UpdateDriver command)
        {
            var vehicle = command.Vehicle;
            await _driverService.SetVehicle(command.UserId, vehicle.Brand, vehicle.Name);
        }
    }
}