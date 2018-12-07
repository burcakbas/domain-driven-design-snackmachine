using SnackMachines.Domain;
using SnackMachines.SharedKernel;
using System;
using Xunit;
using FluentAssertions;

namespace SnackMachines.Tests
{
    public class SnackMachineTest
    {
        [Fact]
        public void Return_money_empties_money_in_transaction()
        {
            var snackMachine = SnackMachineFactory.Create();
            snackMachine.InsertMoney(Money.Dollar);

            snackMachine.ReturnMoney();

            snackMachine.MoneyInTransaction.Amount.Should().Be(0m);
        }


    }
}
