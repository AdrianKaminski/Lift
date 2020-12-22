using System;
using System.Threading.Tasks;
using Lift.Infrastructure.Commands;
using Lift.Infrastructure.Commands.Drivers;
using Lift.Infrastructure.Services;

namespace Lift.Infrastructure.Handlers.Drivers
{
    public class DeleteDriverHandler : ICommandHandler<DeleteDriver>
    {
        private readonly IDriverService _driverService;

        public DeleteDriverHandler(IDriverService driverService)
        {
            _driverService = driverService;
        }

        public async Task HandleAsync(DeleteDriver command)
        {
            await _driverService.DeleteAsync(command.UserId);
        }
    }
}