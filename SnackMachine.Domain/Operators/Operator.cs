using SnackMachines.Common;
using System.Collections.Generic;

namespace SnackMachines.Domain.Operators
{
    public class Operator : Entity
    {
        public void LoadSlots(SnackMachine snackMachine, IList<Product> products)
        {
            for (int i = 0; i < snackMachine.Slots.Count; i++)
            {
                var slot = snackMachine.Slots[i];
                slot.Products.Add(products[i % 4]);
            }
        }
    }
}
