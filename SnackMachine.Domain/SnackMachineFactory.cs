using System;
using System.Collections.Generic;
using System.Text;

namespace SnackMachines.Domain
{
    public class SnackMachineFactory
    {
        private static List<int> availableSlotCapacities = new List<int> { 5, 10, 15, 20 };
        public static SnackMachine Create(int slotCapacity = 15)
        {
            if (!availableSlotCapacities.Contains(slotCapacity))
            {
                throw new InvalidOperationException("Incorrect slot capacity!");
            }
            var snackMachine = new SnackMachine(new List<Slot>());
            for (int i = 0; i < slotCapacity; i++)
            {
                snackMachine.Slots.Add(new Slot());
            }
            return snackMachine;
        }
    }
}
