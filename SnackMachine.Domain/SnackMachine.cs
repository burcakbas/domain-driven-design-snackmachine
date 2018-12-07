using SnackMachines.Common;
using SnackMachines.SharedKernel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SnackMachines.Domain
{
    public sealed class SnackMachine : Entity
    {
        public Money MoneyInside { get; private set; } = Money.None;
        public Money MoneyInTransaction { get; private set; } = Money.None;
        public IList<Slot> Slots { get; internal set; }
        public int SlotCapacity { get; }

        internal SnackMachine(IList<Slot> slots)
        {
            Slots = slots;
            SlotCapacity = slots.Count;
        }
        public void InsertMoney(Money money)
        {
            MoneyInside += money;
            MoneyInTransaction += money;

        }
        public void ReturnMoney()
        {
            MoneyInside -= MoneyInTransaction;
            MoneyInTransaction = Money.None;
        }

        public void InitSlots()
        {

        }

        public bool ValidateSlot(int slotIndex)
        {
            return Slots[slotIndex].Products.Count > 0;
        }

        public bool ValidateSlots()
        {
            return SlotCapacity == Slots.Count && Slots.All(x => x.Products.Count > 0);
        }
    }
}
