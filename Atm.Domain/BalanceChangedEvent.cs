using SnackMachines.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atm.Domain
{
    public class BalanceChangedEvent : IDomainEvent
    {
        public decimal Delta { get; private set; }

        public BalanceChangedEvent(decimal delta)
        {
            Delta = delta;
        }
    }
}
