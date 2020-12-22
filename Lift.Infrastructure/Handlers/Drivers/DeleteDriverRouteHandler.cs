using System.Threading.Tasks;
using Lift.Infrastructure.Commands;
using Lift.Infrastructure.Commands.Drivers;
using Lift.Infrastructure.Services;

namespace Lift.Infrastructure.Handlers.Drivers
{
    public class DeleteDriverRouteHandler : ICommandHandler<DeleteDriverRoute>
    {
        private readonly IDriverRouteService _driverRouteService;

        public DeleteDriverRouteHandler(IDriverRouteService driverRouteService)
        {
            _driverRouteService = driverRouteService;
        }

        public async Task HandleAsync(DeleteDriverRoute command)
        {
            await _driverRouteService.DeleteAsync(command.UserId, command.Name);
        }   
    }
}