using System;
using System.Collections.Generic;

namespace Lift.Infrastructure.DTO
{
    public class DriverDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public VehicleDto Vehicle { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}