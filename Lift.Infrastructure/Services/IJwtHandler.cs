using System;
using Lift.Infrastructure.DTO;

namespace Lift.Infrastructure.Services
{
    public interface IJwtHandler
    {
         JwtDto CreateToken(Guid userId, string role);
    }
}