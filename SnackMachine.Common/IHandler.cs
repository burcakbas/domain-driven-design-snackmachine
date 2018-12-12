using System;
using System.Collections.Generic;
using System.Text;

namespace SnackMachines.Common
{
    public interface IHandler<T> where T : IDomainEvent
    {
        void Handle(T domainEvent);
    }
}
