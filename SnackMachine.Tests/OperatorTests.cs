using SnackMachines.Domain;
using SnackMachines.Domain.Operators;
using Xunit;

namespace SnackMachines.Tests
{
    public class OperatorTests
    {
        public void validate_slots_()
        {
            var sm = new SnackMachine();
            Assert.True(sm.ValidateSlot(1));
            
        }

        [Fact]
        public void load_products()
        {
            var op = new Operator();
            var sm = new SnackMachine();
            op.LoadSlots(sm, Product.GetProducts());

            // validate slots
            var result = true;
            foreach (var slot in sm.Slots)
            {
                if (slot.Products.Count == 0)
                {
                    result = false;
                    break;
                }
            }
            


        }
    }
}
