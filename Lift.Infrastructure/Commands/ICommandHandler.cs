using System.Threading.Tasks;

namespace Lift.Infrastructure.Commands
{
    public interface ICommandHandler<T> where T : ICommand 
    {
        Task HandleAsync(T command); 
    }
}