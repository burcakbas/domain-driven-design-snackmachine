using SnackMachines.Common;

namespace SnackMachine.Utils
{
    public static class Startup
    {
        public static void Init()
        {
            SessionFactory.Init(@"Server=.;Database=DomainDrivenDesign;Trusted_Connection=true");
            DomainEvents.Init();
        }
    }
}
