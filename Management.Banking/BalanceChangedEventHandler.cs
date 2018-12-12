using Atm.Domain;
using SnackMachines.Common;

namespace Management.Banking
{
    public class BalanceChangedEventHandler : IHandler<BalanceChangedEvent>
    {
        public void Handle(BalanceChangedEvent domainEvent)
        {
            //ToDo: Hesap bilgilerine ulaşmak için Repository yerine, daha fazla soyutlama yapılabilir
            var repository = new HeadOfficeRepository();
            HeadOffice headOffice = repository.GetById(1);
            headOffice.ChangeBalance(domainEvent.Delta);
            repository.Save(headOffice);
        }
    }
}
