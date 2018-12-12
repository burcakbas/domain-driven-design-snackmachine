using SnackMachines.Common;
using SnackMachines.SharedKernel;

namespace Management.Banking
{
    public class HeadOffice : Entity, IAggregateRoot
    {
        public virtual decimal Balance { get; protected set; }
        public virtual Money Cash { get; protected set; } = Money.None;

        public virtual void ChangeBalance(decimal delta)
        {
            Balance += delta;
        }

        public virtual void UnloadCashFromSnackMachine(SnackMachines.Domain.SnackMachine snackMachine)
        {
            //Money money = snackMachine.UnloadMoney();
            //Cash += money;
        }

        public virtual void LoadCashToAtm(Atm.Domain.Atm atm)
        {
            atm.LoadMoney(Cash);
            Cash = Money.None;
        }
    }
}
