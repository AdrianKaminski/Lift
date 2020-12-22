using System;
using Lift.Infrastructure.Commands.Drivers.Models;

namespace Lift.Infrastructure.Commands.Drivers
{
    public class UpdateDriver : AuthenticatedCommandBase
    {
        public DriverVehicle Vehicle { get; set; }
    }
}