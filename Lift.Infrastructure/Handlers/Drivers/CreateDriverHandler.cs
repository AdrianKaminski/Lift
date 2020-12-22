using System;
using System.Threading.Tasks;
using Lift.Infrastructure.Commands;
using Lift.Infrastructure.Commands.Drivers;
using Lift.Infrastructure.Services;

namespace Lift.Infrastructure.Handlers.Drivers
{
    public class CreateDriverHandler : ICommandHandler<CreateDriver>
    {
        private readonly IDriverService _driverService;

        public CreateDriverHandler(IDriverService driverService)
        {
            _driverService = driverService;
        }

        public async Task HandleAsync(CreateDriver command)
        {
            await _driverService.CreateAsync(command.UserId);
            var vehicle = command.Vehicle;
            await _driverService.SetVehicle(command.UserId, vehicle.Brand, vehicle.Name);;
        }
    }
}