using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lift.Infrastructure.Commands;
using Lift.Infrastructure.Commands.Drivers;
using Lift.Infrastructure.Services;

namespace Lift.Api.Controllers
{
    [Route("drivers/routes")]
    public class DriversRoutesController : ApiControllerBase
    {
        private readonly IDriverService _driverService;

        public DriversRoutesController(ICommandDispatcher commandDispatcher,
            IDriverService driverService) 
            : base(commandDispatcher)
        {
            _driverService = driverService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateDriverRoute command)
        {
            await DispatchAsync(command);

            return NoContent();
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody]CreateDriverRoute command)
        {
            await DispatchAsync(command);

            return NoContent();
        }                
    }
}