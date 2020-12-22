using System;
using System.Threading.Tasks;

namespace Lift.Infrastructure.Services
{
    public interface IHandlerTaskRunner
    {
        IHandlerTask Run(Func<Task> runAsync);         
    }
}