using SnackMachines.Common;
using SnackMachines.SharedKernel;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SnackMachines.Domain
{
    public sealed class SnackMachine : Entity
    {
        public Money MoneyInside { get; private set; } = Money.None;
        public Money MoneyInTransaction { get; private set; } = Money.None;
        public IList<Slot> Slots { get; }

        public SnackMachine()
        {
            Slots = new List<Slot>(15);
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

        public bool ValidateSlot(int slotIndex)
        {
            return Slots[slotIndex].Products.Count > 0;
        }

        //public bool ValidateSlots()
        //{
        //    return Slots.vali
        //}
    }
}
