using System;
using System.Collections.Generic;
using System.Text;

namespace SnackMachines.Common
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        T GetById(long id);

        void Save(T aggregateRoot);

        IList<T> GetAll();
    }
}
