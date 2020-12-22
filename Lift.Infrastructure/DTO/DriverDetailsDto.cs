using System.Collections.Generic;

namespace Lift.Infrastructure.DTO
{
    public class DriverDetailsDto : DriverDto
    {
        public IEnumerable<RouteDto> Routes { get; set; }
    }
}