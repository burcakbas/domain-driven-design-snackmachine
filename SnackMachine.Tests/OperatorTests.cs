using SnackMachines.Domain;
using SnackMachines.Domain.Operators;
using Xunit;
using FluentAssertions;

namespace SnackMachines.Tests
{
    public class OperatorTests
    {
        [Fact]
        public void validate_slots_()
        {
            var sm = SnackMachineFactory.Create();
            sm.ValidateSlots().Should().BeTrue();
        }

        [Fact]
        public void load_products()
        {
            var op = new Operator();
            var sm = SnackMachineFactory.Create();
            op.LoadSlots(sm, Product.GetProducts());

            sm.ValidateSlots().Should().BeTrue();
        }

        [Fact]
        public void remove_slots_and_validate()
        {
            var op = new Operator();
            var sm = SnackMachineFactory.Create();
            op.LoadSlots(sm, Product.GetProducts());

            sm.Slots.RemoveAt(0);

            sm.ValidateSlots().Should().BeFalse();
        }
    }
}
