using System;
using Lift.Infrastructure.Commands.Drivers.Models;

namespace Lift.Infrastructure.Commands.Drivers
{
    public class CreateDriver : AuthenticatedCommandBase
    {
        public DriverVehicle Vehicle { get; set; }
    }
}