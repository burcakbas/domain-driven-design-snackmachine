using System;
using System.Collections.Generic;
using System.Text;

namespace SnackMachines.Common
{
    public interface IRepository<T> where T : IAggregateRoot
    {

    }
}
