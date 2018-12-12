using Atm.Domain;
using FluentAssertions;
using SnackMachines.Common;
using SnackMachines.SharedKernel;
using Xunit;

namespace SnackMachines.Tests
{
    public class AtmTests
    {
        [Fact]
        public void Take_money_raises_an_event()
        {
            Startup.Init();
            Atm.Domain.Atm atm = new Atm.Domain.Atm();
            atm.LoadMoney(Money.Dollar);

            atm.TakeMoney(1m);

            var balanceChangedEvent = atm.DomainEvents[0] as BalanceChangedEvent;
            balanceChangedEvent.Should().NotBeNull();
            balanceChangedEvent.Delta.Should().Be(1.01m);
        }
    }
}
