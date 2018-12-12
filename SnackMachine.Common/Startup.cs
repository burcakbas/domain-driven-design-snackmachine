namespace SnackMachines.Common
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
