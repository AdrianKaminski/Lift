using AutoMapper;
using Lift.Core.Domain;
using Lift.Infrastructure.DTO;

namespace Lift.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<Driver, DriverDto>();
                cfg.CreateMap<Driver, DriverDetailsDto>();
                cfg.CreateMap<Node, NodeDto>();
                cfg.CreateMap<Route, RouteDto>();
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<Vehicle, VehicleDto>();
            })
            .CreateMapper();
    }
}