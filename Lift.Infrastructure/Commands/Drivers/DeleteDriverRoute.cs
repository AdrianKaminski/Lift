namespace Lift.Infrastructure.Commands.Drivers
{
    public class DeleteDriverRoute : AuthenticatedCommandBase
    {
        public string Name { get; set; }
    }
}