using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lift.Infrastructure.Commands;
using Lift.Infrastructure.Commands.Drivers;
using Lift.Infrastructure.Services;

namespace Lift.Api.Controllers
{
    public class DriversController : ApiControllerBase
    {
        private readonly IDriverService _driverService;

        public DriversController(ICommandDispatcher commandDispatcher,
            IDriverService driverService) 
            : base(commandDispatcher)
        {
            _driverService = driverService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var drivers = await _driverService.BrowseAsync();

            return Json(drivers);
        }  

        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(Guid userId)
        {
            var driver = await _driverService.GetAsync(userId);
            if(driver == null)
            {
                return NotFound();
            }

            return Json(driver);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateDriver command)
        {
            await DispatchAsync(command);

            return Created($"drivers/{command.UserId}", null);
        }     

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UpdateDriver command)
        {
            await DispatchAsync(command);

            return NoContent();
        } 

        [Authorize]
        [HttpDelete("me")]
        public async Task<IActionResult> Delete()
        {
            await DispatchAsync(new DeleteDriver());

            return NoContent();
        }             
    }
}